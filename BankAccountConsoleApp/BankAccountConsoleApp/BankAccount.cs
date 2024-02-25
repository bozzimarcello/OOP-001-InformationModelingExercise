using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountConsoleApp
{
    // Una classe che rappresenta un conto corrente bancario
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
            // DA FARE: Restituisci il numero di conto
        }

        public double GetBalance()
        {
            // DA FARE: Restituisci il saldo corrente
        }

        public string GetOwnerName()
        {
            // DA FARE: restituisci il nome del proprietario
        }

        public string GetAccountType()
        {
            // DA FARE: restituisci il tipo di conto
        }

        //
        // Metodi costruttori pubblici (personalizzare in base alle funzionalità richieste)
        //
        public BankAccount()
        {
            // DA FARE: Inizializza le proprietà con valori predefiniti
        }

        public BankAccount(string accountNumber, double initialBalance)
        {
            // DA FARE: Inizializza le proprietà con i valori forniti
        }

        public BankAccount(string accountNumber, double initialBalance, string ownerName, string accountType)
        {
            // DA FARE: Inizializza le proprietà con tutti i dettagli
        }

        //
        // Metodi pubblici per le operazioni sul conto (implementare la logica qui)
        //
        public void Deposit(double amount)
        {
            // DA FARE: Aggiorna il saldo se il deposito è valido, altrimenti solleva una eccezione
        }

        public void Withdraw(double amount)
        {
            // DA FARE: Aggiorna il saldo se il prelievo è valido, altrimenti solleva una eccezione
        }


    }

}
