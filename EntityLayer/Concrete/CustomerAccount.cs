using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; } //HesapNumarası
        public string CustomerAccountCurrency { get; set; } //HesabınDövizTürü
        public decimal CustomerAccountBalance { get; set; } //HesapBakiye
        public decimal BankBranch { get; set; } //Şube

        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; } //Bire Çok ilişki 


    }
}
