using System.Text.RegularExpressions;
using FluentValidation;

namespace SimpleTransferPlatform.Application.UseCases.Validations;

public static class DocumentValidator
{
    public static IRuleBuilderOptions<T, string> IsValidCpfOrCnpj<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder
            .Must(IsValidCpfOrCnpj)
            .WithMessage("Documento inválido.");
    }

    private static bool IsValidCpfOrCnpj(string document)
    {
        if (String.IsNullOrEmpty(document) || String.IsNullOrWhiteSpace(document))
            return false;

        document = Regex.Replace(document,"[^0-9]", "");

        if (document.Length == 11)
            return IsValidCpf(document);
        
        else if (document.Length == 14)
            return IsValidCnpj(document);

        return false;
    }

    private static bool IsValidCpf(string document)
    {
        if (document.All(c => c == document[0]))
            return false;

        var numbers = document.Select(c => int.Parse(c.ToString())).ToArray();
        
        var sum = 0;
        for (int i = 0; i < 9; i++)
            sum += numbers[i] * (10 - i);

        var remainder = sum % 11;
        var firstDigit = remainder < 2 ? 0 : 11 - remainder;

        if (numbers[9] != firstDigit)
            return false;

        sum = 0;
        for (int i = 0; i < 10; i++)
            sum += numbers[i] * (11 - i);

        remainder = sum % 11;
        var secondDigit = remainder < 2 ? 0 : 11 - remainder;

        return numbers[10] == secondDigit;
    }

    private static bool IsValidCnpj(string cnpj)
    {
        if (cnpj.All(c => c == cnpj[0])) return false;

        var numbers = cnpj.Select(c => int.Parse(c.ToString())).ToArray();

        int[] multipliers1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multipliers2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        int sum = 0;
        for (int i = 0; i < 12; i++)
            sum += numbers[i] * multipliers1[i];

        int remainder = (sum % 11);
        int firstDigit = remainder < 2 ? 0 : 11 - remainder;

        if (numbers[12] != firstDigit)
            return false;

        sum = 0;
        for (int i = 0; i < 13; i++)
            sum += numbers[i] * multipliers2[i];

        remainder = (sum % 11);
        int secondDigit = remainder < 2 ? 0 : 11 - remainder;

        return numbers[13] == secondDigit;
    }
}