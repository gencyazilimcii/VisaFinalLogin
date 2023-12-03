using Microsoft.AspNetCore.Identity;

namespace PresantationLayer.Models
{
	public class CustomerIdentityValidator : IdentityErrorDescriber
	{
		public override IdentityError PasswordTooShort(int length) //şifrenin çok kısa olduğunu bildiren bir methoddur
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort", //methodun keyi
				Description = $"Parola en az {length} karakter olmalıdır" //Default olarak gelen değer 6
			};
		}

		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper", //methodun keyi
				Description = "Lütfen en az 1 büyük harf giriniz"
			};
		}
	}
}
