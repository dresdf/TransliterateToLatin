using System;
using System.Collections.Generic;
using System.Text;

namespace TransliterateToLatin
{
    class Greek
    {

        public static string GreekToLatin(string input)
        {
            char[] charInput = RemoveDiacritics(input).ToCharArray();
            string output = "";
            for(int i = 0; i <= input.Length - 1; i++)
            {
                switch(charInput[i].ToString())
                {
                    case "Α":
                        if(i + 1 <= input.Length - 1)
                        {
                            switch(charInput[i + 1].ToString())
                            {
                                case "ι":
                                    output = output + "Ai";
                                    i = i + 1;
                                    break;
                                case "υ":
                                    if(i + 2 <= input.Length - 1)
                                    {
                                        switch(charInput[i + 2].ToString())
                                        {
                                            case "β":
                                            case "γ":
                                            case "δ":
                                            case "ζ":
                                            case "λ":
                                            case "μ":
                                            case "ν":
                                            case "ρ":
                                            case "α":
                                            case "ε":
                                            case "η":
                                            case "ι":
                                            case "ο":
                                            case "υ":
                                            case "ω":
                                                output = output + "Av";
                                                i = i + 1;
                                                break;
                                            default:
                                                output = output + "Af";
                                                i = i + 1;
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        output = output + "Av";
                                        i = i + 1;
                                    }

                                    break;
                                default:
                                    output = output + "A";
                                    break;
                            }
                        }
                        else
                        {
                            output = output + "A";
                        }

                        break;
                    case "α":
                        if(i + 1 <= input.Length - 1)
                        {
                            switch(charInput[i + 1].ToString())
                            {
                                case "ι":
                                    output = output + "ai";
                                    i = i + 1;
                                    break;


                                case "υ":
                                    if(i + 2 <= input.Length - 1)
                                    {
                                        switch(charInput[i + 2].ToString())
                                        {
                                            case "β":
                                            case "γ":
                                            case "δ":
                                            case "ζ":
                                            case "λ":
                                            case "μ":
                                            case "ν":
                                            case "ρ":
                                            case "α":
                                            case "ε":
                                            case "η":
                                            case "ι":
                                            case "ο":
                                            case "υ":
                                            case "ω":
                                                output = output + "av";
                                                i = i + 1;
                                                break;


                                            default:
                                                output = output + "af";
                                                i = i + 1;
                                                break;

                                        }
                                    }
                                    else
                                    {
                                        output = output + "av";
                                        i = i + 1;
                                    }

                                    break;
                                default:
                                    output = output + "a";
                                    break;
                            }
                        }
                        else
                        {
                            output = output + "a";
                        }

                        break;
                    case "Β":
                        output = output + "B";
                        break;
                    case "β":
                        output = output + "b";
                        break;
                    case "Γ":
                        if(i + 1 <= input.Length - 1)
                        {
                            switch(charInput[i + 1].ToString())
                            {
                                case "γ":
                                    output = output + "Ng";
                                    i = i + 1;
                                    break;

                                case "κ":
                                    output = output + "Gg";
                                    i = i + 1;
                                    break;


                                case "ξ":
                                    output = output + "Nx";
                                    i = i + 1;
                                    break;


                                case "χ":
                                    output = output + "Nch";
                                    i = i + 1;
                                    break;


                                default:
                                    output = output + "G";
                                    i = i + 1;
                                    break;

                            }
                        }
                        else
                        {
                            output = output + "G";
                        }

                        break;
                    case "γ":
                        if(i + 1 <= input.Length - 1)
                        {
                            switch(charInput[i + 1].ToString())
                            {
                                case "γ":
                                    output = output + "ng";
                                    i = i + 1;
                                    break;


                                case "κ":
                                    output = output + "gg";
                                    i = i + 1;
                                    break;

                                case "ξ":
                                    output = output + "nx";
                                    i = i + 1;
                                    break;

                                case "χ":
                                    output = output + "nch";
                                    i = i + 1;
                                    break;

                                default:
                                    output = output + "g";
                                    i = i + 1;
                                    break;
                            }
                        }
                        else
                        {
                            output = output + "g";
                        }

                        break;
                    case "Δ":
                        output = output + "D";
                        break;
                    case "δ":
                        output = output + "d";
                        break;
                    case "Ε":
                        if(i + 1 <= input.Length - 1)
                        {
                            switch(charInput[i + 1].ToString())
                            {
                                case "ι":
                                    output = output + "Ei";
                                    i = i + 1;
                                    break;

                                case "υ":
                                    if(i + 2 <= input.Length - 1)
                                    {
                                        switch(charInput[i + 2].ToString())
                                        {
                                            case "β":
                                            case "γ":
                                            case "δ":
                                            case "ζ":
                                            case "λ":
                                            case "μ":
                                            case "ν":
                                            case "ρ":
                                            case "α":
                                            case "ε":
                                            case "η":
                                            case "ι":
                                            case "ο":
                                            case "υ":
                                            case "ω":
                                                output = output + "Ev";
                                                i = i + 1;
                                                break;


                                            default:
                                                output = output + "Ef";
                                                i = i + 1;
                                                break;


                                        }
                                    }
                                    else
                                    {
                                        output = output + "Ev";
                                        i = i + 1;
                                    }

                                    break;
                                default:
                                    output = output + "E";
                                    break;
                            }
                        }
                        else
                        {
                            output = output + "E";
                        }

                        break;
                    case "ε":
                        if(i + 1 <= input.Length - 1)
                        {
                            switch(charInput[i + 1].ToString())
                            {
                                case "ι":
                                    output = output + "ei";
                                    i = i + 1;
                                    break;


                                case "υ":
                                    if(i + 2 <= input.Length - 1)
                                    {
                                        switch(charInput[i + 2].ToString())
                                        {
                                            case "β":
                                            case "γ":
                                            case "δ":
                                            case "ζ":
                                            case "λ":
                                            case "μ":
                                            case "ν":
                                            case "ρ":
                                            case "α":
                                            case "ε":
                                            case "η":
                                            case "ι":
                                            case "ο":
                                            case "υ":
                                            case "ω":
                                                output = output + "ev";
                                                i = i + 1;
                                                break;


                                            default:
                                                output = output + "ef";
                                                i = i + 1;
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        output = output + "ev";
                                        i = i + 1;
                                    }

                                    break;
                                default:
                                    output = output + "e";
                                    break;
                            }
                        }
                        else
                        {
                            output = output + "e";
                        }

                        break;
                    case "Ζ":
                        output = output + "Z";
                        break;
                    case "ζ":
                        output = output + "z";
                        break;
                    case "Η":
                        if(i + 1 <= input.Length - 1)
                        {
                            switch(charInput[i + 1].ToString())
                            {
                                case "υ":
                                    if(i + 2 <= input.Length - 1)
                                    {
                                        switch(charInput[i + 2].ToString())
                                        {
                                            case "β":
                                            case "γ":
                                            case "δ":
                                            case "ζ":
                                            case "λ":
                                            case "μ":
                                            case "ν":
                                            case "ρ":
                                            case "α":
                                            case "ε":
                                            case "η":
                                            case "ι":
                                            case "ο":
                                            case "υ":
                                            case "ω":
                                                output = output + "Iv";
                                                i = i + 1;
                                                break;


                                            default:
                                                output = output + "If";
                                                i = i + 1;
                                                break;

                                        }
                                    }
                                    else
                                    {
                                        output = output + "Iv";
                                        i = i + 1;
                                    }

                                    break;
                                default:
                                    output = output + "I";
                                    break;
                            }
                        }
                        else
                        {
                            output = output + "I";
                        }

                        break;
                    case "η":
                        if(i + 1 <= input.Length - 1)
                        {
                            switch(charInput[i + 1].ToString())
                            {
                                case "υ":
                                    if(i + 2 <= input.Length - 1)
                                    {
                                        switch(charInput[i + 2].ToString())
                                        {
                                            case "β":
                                            case "γ":
                                            case "δ":
                                            case "ζ":
                                            case "λ":
                                            case "μ":
                                            case "ν":
                                            case "ρ":
                                            case "α":
                                            case "ε":
                                            case "η":
                                            case "ι":
                                            case "ο":
                                            case "υ":
                                            case "ω":
                                                output = output + "iv";
                                                i = i + 1;
                                                break;


                                            default:
                                                output = output + "if";
                                                i = i + 1;
                                                break;


                                        }
                                    }
                                    else
                                    {
                                        output = output + "iv";
                                        i = i + 1;
                                    }

                                    break;
                                default:
                                    output = output + "i";
                                    break;
                            }
                        }
                        else
                        {
                            output = output + "i";
                        }

                        break;
                    case "Θ":
                        output = output + "Th";
                        break;
                    case "θ":
                        output = output + "th";
                        break;
                    case "Ι":
                        output = output + "I";
                        break;
                    case "ι":
                        output = output + "i";
                        break;
                    case "Κ":
                        output = output + "K";
                        break;
                    case "κ":
                        output = output + "k";
                        break;
                    case "Λ":
                        output = output + "L";
                        break;
                    case "λ":
                        output = output + "l";
                        break;
                    case "Μ":
                        if(i + 1 <= input.Length - 1)
                        {
                            switch(charInput[i + 1].ToString())
                            {
                                case "π":
                                    if(i == 0 || charInput[i - 1].ToString() == " ")
                                    {
                                        output = output + "B";
                                        i = i + 1;
                                        break;
                                    }
                                    else
                                    {
                                        output = output + "Mp";
                                        i = i + 1;
                                        break;
                                    }


                                default:
                                    output = output + "M";
                                    break;
                            }
                        }
                        else
                        {
                            output = output + "M";
                        }

                        break;
                    case "μ":
                        if(i + 1 <= input.Length - 1)
                        {
                            switch(charInput[i + 1].ToString())
                            {
                                case "π":
                                    if(i == 0 || charInput[i - 1].ToString() == " ")
                                    {
                                        output = output + "b";
                                        i = i + 1;
                                        break;
                                    }
                                    else
                                    {
                                        output = output + "mp";
                                        i = i + 1;
                                        break;
                                    }


                                default:
                                    output = output + "m";
                                    break;
                            }
                        }
                        else
                        {
                            output = output + "m";
                        }

                        break;
                    case "Ν":
                        output = output + "N";
                        break;
                    case "ν":
                        output = output + "n";
                        break;
                    case "Ξ":
                        output = output + "X";
                        break;
                    case "ξ":
                        output = output + "x";
                        break;
                    case "Ο":
                        output = output + "O";
                        break;
                    case "ο":
                        output = output + "o";
                        break;
                    case "Π":
                        output = output + "P";
                        break;
                    case "π":
                        output = output + "p";
                        break;
                    case "Ρ":
                        output = output + "R";
                        break;
                    case "ρ":
                        output = output + "r";
                        break;
                    case "Σ":
                        output = output + "S";
                        break;
                    case "σ":
                        output = output + "s";
                        break;
                    case "ς":
                        output = output + "s";
                        break;
                    case "Τ":
                        output = output + "T";
                        break;
                    case "τ":
                        output = output + "t";
                        break;
                    case "Υ":
                        output = output + "Y";
                        break;
                    case "υ":
                        output = output + "y";
                        break;
                    case "Φ":
                        output = output + "F";
                        break;
                    case "φ":
                        output = output + "f";
                        break;
                    case "Χ":
                        output = output + "Ch";
                        break;
                    case "χ":
                        output = output + "ch";
                        break;
                    case "Ψ":
                        output = output + "Ps";
                        break;
                    case "ψ":
                        output = output + "ps";
                        break;
                    case "Ω":
                        output = output + "O";
                        break;
                    case "ω":
                        output = output + "o";
                        break;
                    default:
                        output = output + charInput[i].ToString();
                        break;
                }
            }
            return output;
        }

        private static string RemoveDiacritics(string input)
        {
            char[] charInput = input.ToCharArray();
            string output = "";
            for(int i = 0; i <= input.Length - 1; i++)
            {
                switch(charInput[i].ToString())
                {
                    case "Ά":
                        output = output + "Α";
                        break;
                    case "ά":
                        output = output + "α";
                        break;
                    case "Έ":
                        output = output + "Ε";
                        break;
                    case "έ":
                        output = output + "ε";
                        break;
                    case "Ή":
                        output = output + "Η";
                        break;
                    case "ή":
                        output = output + "η";
                        break;
                    case "Ί":
                        output = output + "Ι";
                        break;
                    case "ί":
                        output = output + "ι";
                        break;
                    case "Ύ":
                        output = output + "Υ";
                        break;
                    case "ύ":
                        output = output + "υ";
                        break;
                    case "Ό":
                        output = output + "Ο";
                        break;
                    case "ό":
                        output = output + "ο";
                        break;
                    case "Ώ":
                        output = output + "Ω";
                        break;
                    case "ώ":
                        output = output + "ω";
                        break;
                    default:
                        output = output + charInput[i].ToString();
                        break;
                }
            }
            return output;
        }
    }
}
