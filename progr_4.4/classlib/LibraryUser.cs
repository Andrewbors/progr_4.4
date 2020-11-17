using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class LibraryUser : People
    {
        private int TicketId;
        private String TicketDate;
        private int Payment;

        public int GetTicketId() {
            return TicketId;
        }

        public String GetTicketDate() {
            return TicketDate;
        }

        public int GetPayment() {
            return Payment;
        }

        public void SetTicket(int TicketId) {
            this.TicketId = TicketId;
        }

        public void SetTicketDate(String TicketDate) {
            this.TicketDate = TicketDate;
        }

        public void SetPayment(int Payment) {
            this.Payment = Payment;
        }

        public LibraryUser() {
        }


        public LibraryUser(int TicketId, String TicketDate, int Payment) {
            this.TicketId = TicketId;
            this.TicketDate = TicketDate;
            this.Payment = Payment;
        }

        public LibraryUser(String Name, String SecondName, String Birthday, int TicketId, String TicketDate, int Payment) 
        : base(Name, SecondName, Birthday) {
            this.TicketId = TicketId;
            this.TicketDate = TicketDate;
            this.Payment = Payment;
        }

        public LibraryUser(LibraryUser User) {
            this.TicketId = User.GetTicketId();
            this.TicketDate = User.GetTicketDate();
            this.Payment = User.GetPayment();   
        }


        public override void ShowInfo() {
            Console.WriteLine(TicketId);
            Console.WriteLine(TicketDate);
            Console.WriteLine(Payment);
        }
    }
}
