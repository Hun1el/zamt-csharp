using System;

namespace DiscountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userAuthorized; // = AuthorizeUser();
            {
                userAuthorized = false;

                string[] loginList = { "Админ", "Иванова", "Петрова", "Сергеева", "Васильева", "Семёнова" };
                string[] passwordList = { "000", "111", "222", "333", "444", "555" };

                int authorizationAttemptCounter = 0;
                const int ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS = 3;
                bool authorizationAttemptAvailable = authorizationAttemptCounter < ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;

            BeginWhile:
                while (authorizationAttemptAvailable)
                {
                //BeginWhile:
                    string login, password; // = InputLoginAndPassword();
                    {
                        Console.Write("Введите логин : ");
                        login = Console.ReadLine();
                        Console.Write("Введите пароль: ");
                        password = Console.ReadLine();
                    }

                    // authorized = TryAuthorizeUser(login, password);
                    {
                        int index = 0;

                        while (index < loginList.Length && index < passwordList.Length)
                        {
                            bool loginMatched, passwordMatched; // = MatchLoginAndPassword()
                            {
                                string loginByCurrentIndex = loginList[index];
                                loginMatched = loginByCurrentIndex == login;
                                string passwordByCurrentIndex = passwordList[index];
                                passwordMatched = passwordByCurrentIndex == password;
                            }

                            if (loginMatched && passwordMatched)
                            {
                                userAuthorized = true;
                                break;
                            }
                            else
                            {
                                index++;
                            }
                        }
                    }

                    if (userAuthorized)
                    {
                        Console.WriteLine("Вы успешно авторизованы.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Логин или пароль введены не правильно.");
                        authorizationAttemptAvailable = ++authorizationAttemptCounter < ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;

                        if (authorizationAttemptAvailable)
                        {
                            goto BeginWhile; //continue;
                        }
                        else
                        {
                            Console.WriteLine("Вы исчерпали количество попыток авторизации. Обратитесь к администратору.");
                            goto EndWhile; // break;
                        }
                    }
                }
            EndWhile:;
            }
            //EndWhile://;

            // Run (userAuthorized);
            {
                while (userAuthorized)
                {
                    string countryCode;
                    decimal tileQuontiti, tilePrice;
                    // countryCode, tileQuontiti, tilePrice = RunInputUserInterface ()
                    {
                        Console.WriteLine("Нажмите Enter, для начала обслуживания нового клиента.");
                        Console.ReadKey();

                        const string COUNTRY_CODES =
                            "===========================================================\n" +
                            "Азербайджан (994) |  Киргизия    (996) | Таджикистан  (992)\n" +
                            "Армения     (374) |  Латвия      (371) | Туркмения    (993)\n" +
                            "Беларусь    (375) |  Литва       (370) | Узбекистан   (998)\n" +
                            "Грузия      (995) |  Молдова     (373) | Украина      (380)\n" +
                            "Казахстан  (007К) |  Россия      (007) | Эстония      (372)\n" +
                            "-----------------------------------------------------------";

                        Console.WriteLine(COUNTRY_CODES);

                        // countryCode = ProcessCountryCode (countryCode)
                        {
                            bool countryCodeIsCorrect;

                            do
                            {
                                Console.Write("Телефонный код страны : ");
                                countryCode = Console.ReadLine();

                                // countryCode = DetectKazakhstanCode (countryCode)
                                {
                                    const string KAZAKHSTAN_CODE = "007";
                                    const string /*UPPERCASE_ENGLISH_LETTER_K = "K",*/ LOWERCASE_ENGLISH_LETTER_k = "k",
                                                 UPPERCASE_RUSSIAN_LETTER_K = "К", LOWERCASE_RUSSIAN_LETTER_k = "к";
                                    bool countryCodeIsKazakhstanCodeAndAnyLetterK =
                                                 //countryCode == (KAZAKHSTAN_CODE + UPPERCASE_ENGLISH_LETTER_K) ||
                                                 countryCode == (KAZAKHSTAN_CODE + LOWERCASE_ENGLISH_LETTER_k) ||
                                                 countryCode == (KAZAKHSTAN_CODE + UPPERCASE_RUSSIAN_LETTER_K) ||
                                                 countryCode == (KAZAKHSTAN_CODE + LOWERCASE_RUSSIAN_LETTER_k);

                                    if (countryCodeIsKazakhstanCodeAndAnyLetterK)
                                    {
                                        const string UPPERCASE_ENGLISH_LETTER_K = "K";
                                        countryCode = KAZAKHSTAN_CODE + UPPERCASE_ENGLISH_LETTER_K;
                                    }
                                }

                                // countryCodeIsCorrect = CheckCountryCode (countryCode)
                                {
                                    const string UPPERCASE_ENGLISH_LETTER_K = "K";
                                    const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                                                 GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K, KYRGYZSTAN_CODE = "996",
                                                 LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                                                 RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993",
                                                 UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                                    switch (countryCode)
                                    {
                                        case AZERBAIJAN_CODE:
                                        case ARMENIA_CODE:
                                        case BELARUS_CODE:
                                        case GEORGIA_CODE:
                                        case KAZAKHSTAN_CODE:
                                        case KYRGYZSTAN_CODE:
                                        case LATVIA_CODE:
                                        case LITHUANIA_CODE:
                                        case MOLDOVA_CODE:
                                        case RUSSIA_CODE:
                                        case TAJIKISTAN_CODE:
                                        case TURKMENISTAN_CODE:
                                        case UZBEKISTAN_CODE:
                                        case UKRAINE_CODE:
                                        case ESTONIA_CODE:
                                            {
                                                countryCodeIsCorrect = true;
                                                break;
                                            }
                                        default:
                                            {
                                                countryCodeIsCorrect = false;
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"Вы ввели несуществующий код: {countryCode}!");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                    }
                                }
                            }
                            while (countryCodeIsCorrect == false);

                        }

                        Console.Write("Количество плитки     : ");
                        string stringQuontiti = Console.ReadLine();
                        tileQuontiti = Convert.ToDecimal(stringQuontiti);

                        Console.Write("Цена за 1 м.кв. плитки: ");
                        string stringPrice = Console.ReadLine();
                        tilePrice = Convert.ToDecimal(stringPrice);
                    }

                    decimal rate;
                    // rate = CalculatePriceRate (countryCode)
                    {
                        const string UPPERCASE_ENGLISH_LETTER_K = "K";
                        const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                                     GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K, KYRGYZSTAN_CODE = "996",
                                     LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                                     RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993",
                                     UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                        switch (countryCode)
                        {
                            case AZERBAIJAN_CODE:
                                {
                                    const decimal AZERBAIJAN_RATE = 1.07m;
                                    rate = AZERBAIJAN_RATE;
                                    break;
                                }
                            case ARMENIA_CODE:
                                {
                                    const decimal ARMENIA_RATE = .95m;
                                    rate = ARMENIA_RATE;
                                    break;
                                }
                            case BELARUS_CODE:
                                {
                                    const decimal BELARUS_RATE = 1;
                                    rate = BELARUS_RATE;
                                    break;
                                }
                            case GEORGIA_CODE:
                                {
                                    const decimal GEORGIA_RATE = .94m;
                                    rate = GEORGIA_RATE;
                                    break;
                                }
                            case KAZAKHSTAN_CODE:
                                {
                                    const decimal KAZAKHSTAN_RATE = .79m;
                                    rate = KAZAKHSTAN_RATE;
                                    break;
                                }
                            case KYRGYZSTAN_CODE:
                                {
                                    const decimal KYRGYZSTAN_RATE = .83m;
                                    rate = KYRGYZSTAN_RATE;
                                    break;
                                }
                            case MOLDOVA_CODE:
                                {
                                    const decimal MOLDOVA_RATE = .97m;
                                    rate = MOLDOVA_RATE;
                                    break;
                                }
                            case RUSSIA_CODE:
                                {
                                    const decimal RUSSIA_RATE = 1;
                                    rate = RUSSIA_RATE;
                                    break;
                                }
                            case TAJIKISTAN_CODE:
                                {
                                    const decimal TAJIKISTAN_RATE = .76m;
                                    rate = TAJIKISTAN_RATE;
                                    break;
                                }
                            case TURKMENISTAN_CODE:
                                {
                                    const decimal TURKMENISTAN_RATE = .81m;
                                    rate = TURKMENISTAN_RATE;
                                    break;
                                }
                            case UZBEKISTAN_CODE:
                                {
                                    const decimal UZBEKISTAN_RATE = .98m;
                                    rate = UZBEKISTAN_RATE;
                                    break;
                                }
                            case UKRAINE_CODE:
                                {
                                    const decimal UKRAINE_RATE = 1;
                                    rate = UKRAINE_RATE;
                                    break;
                                }
                            case LATVIA_CODE:
                            case LITHUANIA_CODE:
                            case ESTONIA_CODE:
                                {
                                    const decimal LATVIA_LITHUANIA_ESTONIA_RATE = 1.12m;
                                    rate = LATVIA_LITHUANIA_ESTONIA_RATE;
                                    break;
                                }
                            default:
                                {
                                    rate = 0;
                                    break;
                                }
                        }
                    }

                    decimal tilePriceWithRate = tilePrice * rate;
                    decimal tileCost = tileQuontiti * tilePriceWithRate; // руб.

                    decimal discount; // руб.
                    {
                        decimal discountPersentage; // %
                        {
                            bool discount20PctAvailable, discount50PctAvailable;
                            {
                                const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500,
                                              MIN_TILE_QTY_FOR_DISCOUNT_50_PCT = 1000; // м.кв.

                                discount20PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT &&
                                                         tileQuontiti < MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;

                                discount50PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                            }

                            if (discount20PctAvailable)
                            {
                                discountPersentage = 20; // %
                            }
                            else if (discount50PctAvailable)
                            {
                                discountPersentage = 50; // %
                            }
                            else
                            {
                                discountPersentage = 0; // %
                            }
                        }

                        discount = tileCost / 100 * discountPersentage;
                    }

                    decimal paymentAmount = tileCost - discount;

                    // RunOutputUserInterface (tilePriceWithRate, tileCost, discount, paymentAmount)
                    {
                        Console.WriteLine($"Цена с коэффициентом  : {tilePriceWithRate} руб.");
                        Console.WriteLine($"Общая стоимость плитки: {tileCost} руб.");
                        Console.WriteLine($"Скидка                : {discount} руб.");
                        Console.WriteLine($"Сумма к оплате        : {paymentAmount} руб.");
                    }
                }
            }
        }
    }
}
