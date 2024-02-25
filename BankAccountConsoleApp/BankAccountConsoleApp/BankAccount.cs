using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountConsoleApp
{
    // Class representing a Bank Account
    // una classe che rappresenta un conto corrente bancario
    public class BankAccount
    {
        //
        // Attributi (tutti privati per incapsulamento)
        //
        private string _accountNumber;
        private double _balance;
        private string _ownerName;
        private string _accountType;

        //
        // Metodi getter pubblici
        //
        public string GetAccountNumber()
        {
            // restituisci il numero di conto
            return string.Empty;
        }

        public double GetBalance()
        {
            // Restituisci il saldo corrente
            return 0.0;
        }

        public string GetOwnerName()
        {
            // restituisci il nome del proprietario
            return string.Empty;
        }

        public string GetAccountType()
        {
            // restituisci il tipo di conto
            return string.Empty;
        }

        //
        // Metodi costruttori pubblici (personalizzare in base alle funzionalità richieste)
        //
        public BankAccount()
        {
            // Inizializza le proprietà con valori predefiniti
        }

        public BankAccount(string accountNumber, double initialBalance)
        {
            // Inizializza le proprietà con i valori forniti
        }

        public BankAccount(string accountNumber, double initialBalance, string ownerName, string accountType)
        {
            // Inizializza le proprietà con tutti i dettagli
        }

        //
        // Metodi pubblici per le operazioni sul conto (implementare la logica qui)
        //
        public void Deposit(double amount)
        {
            // Update balance if deposit is valid
            // Aggiorna il saldo se il deposito è valido, altrimenti solleva una eccezione
        }

        public void Withdraw(double amount)
        {
            // Update balance if withdrawal is valid
            // Aggiorna il saldo se il prelievo è valido, altrimenti solleva una eccezione
        }


    }

}
