using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Proszę podać Imię")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podać Nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podać Adres e-mail")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy format adresu e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać Hasło")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić Hasło")]
        [Compare("Haslo", ErrorMessage = "Hasło i potwierdzenie hasła nie pasują")]
        public string PotwierdzenieHasla { get; set; }

        [Required(ErrorMessage = "Proszę podać Nr telefonu")]
        [Phone(ErrorMessage = "Nieprawidłowy format numeru telefonu")]
        public string NrTelefonu { get; set; }

        [Required(ErrorMessage = "Proszę podać Wiek")]
        [Range(10, 80, ErrorMessage = "Wiek musi być pomiędzy 10 a 80")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Proszę wybrać Miasto")]
        public string Miasto { get; set; }
        public string? SuccessMessage { get; set; }

    }
}
