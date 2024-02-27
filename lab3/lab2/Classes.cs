using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace lab2
{
    //Владелец, депозит, список аккаунтов
    [Serializable]
    public class Owner
    {
        public string UserName { get; set; }

        [Required(ErrorMessage = "Поле фамилии обязательно для заполнения.")]
        [RegularExpression(@"^[a-zA-Z\-]+$", ErrorMessage = "Фамилия должна состоять только из букв и дефисов.")]
        public string UserSurname { get; set; }
        public string UserFathername { get; set; }

        [BelarusPassportNumber(ErrorMessage = "Неправильный номер паспорта")]
        public string PassportNumber { get; set; }
        public string UserBirthday { get; set; }
    }

    [Serializable]
    public class Deposit
    {
        [Range(1, 100, ErrorMessage = "Номер счёта должен быть в диапазоне от 1 до 100")]
        public int Number { get; set; }
        public string DepositType { get; set; }
        public int Balance { get; set; }
        public DateTime DateDeposit { get; set; }
        public bool Ads { get; set; }
        public bool Banking { get; set; }
        public bool SMS { get; set; }
        public string Info { get; set; }
        public Owner Owner { get; set; }
    }

    [Serializable]
    public class Account
    {
        public List<Deposit> DepositList { get; set; }
        public Owner Owner { get; set; }
        public Account()
        {
            Owner = new Owner();
            DepositList = new List<Deposit>();
        }
    }

    [Serializable]
    public class AccountList
    {
        private static AccountList _elements;
        private List<Deposit> _accounts;

        private AccountList()
        {
            _accounts = new List<Deposit>();
        }

        public static AccountList Elements
        {
            get
            {
                if (_elements == null)
                    _elements = new AccountList();

                return _elements;
            }
        }

        public void AddElem(Deposit account) =>
            _accounts.Add(account);

        public List<Deposit> GetAccounts() => _accounts;
    }

    //Операции
    public enum EOperationTypes
    {
        Перевод,
        Снятие,
        Пополнение
    }

    [Serializable]
    public class Operation
    {
        public EOperationTypes OperationType { get; set; }
        public int ID { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public string Info { get; set; }
    }

    [Serializable]
    public class ListOperations
    {
        public List<Operation> operations;
        public ListOperations()
        {
            operations = new List<Operation>();
        }
    }

    //Пользовательский валидатор
    public class BelarusPassportNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null && value is string passportNumber)
            {
                bool isValid = ValidateBelarusPassportNumber(passportNumber);

                if (!isValid)
                {
                    return new ValidationResult(ErrorMessage);
                }
            }

            return ValidationResult.Success;
        }

        private bool ValidateBelarusPassportNumber(string passportNumber)
        {
            Regex regex = new Regex(@"^\d{5}");

            return regex.IsMatch(passportNumber);
        }
    }
}
