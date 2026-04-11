using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcecoesPersonalizadas.Entites.Exceptions;

namespace ExcecoesPersonalizadas.Entites
{
    sealed class Reservation
    {
        public int RoomNumber { get;private set; }
        public DateTime Checkin { get; private set; }

        public DateTime Checkout { get; private set; }


        public Reservation() { }
        public Reservation(int roomNumber) : this() { RoomNumber = roomNumber; } 

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout) : this(roomNumber)
        {
            if (checkin > checkout) {throw new DomainException("Error in reservation: Check-out date must be after check-in date"); }
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }
        public int Duration() { 
            TimeSpan time = Checkout - Checkin;
            return time.Days;
        }
        public void UpdateDates(DateTime checkin,DateTime checkout)
        {
            
                
                if (checkin < DateTime.Now || checkout <= DateTime.Now) { throw new DomainException("Invalid reservation"); }
                if (checkin > checkout) { throw new DomainException("Error in reservation: Check-out date must be after check-in date"); }
                Checkin = checkin;
                Checkout = checkout;
           
        }
        public sealed override string ToString()
        {
            return 
                $"Reservation: Room {RoomNumber}, check-in: {Checkin.ToString("dd/MM/yyyy")}, check-out: {Checkout.ToString("dd/MM/yyyy")}, {Duration()} nights \n";
        }

    }
}
