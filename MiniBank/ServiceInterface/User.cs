using System.Collections.Generic;
using System.Linq;
using Dal;

namespace ServiceInterface
{
    public class User : IUser
    {
        private readonly MiniBankDBEntities _context;

        public User()
        {
            _context = new MiniBankDBEntities();
        }

        public List<string> GetUserNames()
        {
            return _context.Users.Select(user => user.u_firstName).ToList();
        }

        public List<PaymentModel> GetUserPayments(int userId)
        {
            List<Payment> payments = _context.Payments.Where(p => p.u_userId == userId).ToList();
            var fullName = _context.Users.Where(u => u.u_userId == userId)
                                         .Select(u => new { FirstName = u.u_firstName, LastName = u.u_lastName }).ToList();
            List<PaymentModel> result = payments.Select(p => new PaymentModel
            {
                PaymentId = p.p_paymentId,
                FirstName = fullName[0].FirstName,
                LastName = fullName[0].LastName,
                Sum = p.p_payment
            }).ToList();
            return result;
        }
    }
}
