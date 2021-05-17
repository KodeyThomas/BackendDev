using System;

namespace assignment1
{
    class Program
    {
        public static void Main(string[] args)
        {
            String a = "/.-";
            String b = "/-...";
            String c = "/-.-.";
            String d = "/-..";
            String e = "/.";
            String f = "/..-.";
            String g = "/--.";
            String h = "/....";
            String i = "/..";
            String j = "/.---";
            String k = "/-.-";
            String l = "/.-..";
            String m = "/--";
            String n = "/-.";
            String o = "/---";
            String p = "/.--.";
            String q = "/--.-";
            String r = "/.-.";
            String s = "/...";
            String t = "/-";
            String u = "/..-";
            String v = "/...-";
            String w = "/.--";
            String x = "/-..-";
            String y = "/-.--";
            String z = "/--..";

            String one = "/.----";
            String two = "/..---";
            String three = "/...--";
            String four = "/....-";
            String five = "/.....";
            String six = "/-....";
            String seven = "/--...";
            String eight = "/---..";
            String nine = "/----.";
            String zero = "/------";

            Console.WriteLine("Please enter a short sentence: ");
            String input = Console.ReadLine();

            char[] arr;

            arr = input.ToCharArray();

            foreach (char c in arr)
            {
                switch (c)
                {
                    case "a":
                        console.Write(a);
                        break;
                    case "b":
                        console.Write(b);
                        break;
                    case "c":
                        console.Write(c);
                        break;
                    case "d":
                        console.Write(d);
                        break;
                    case "e":
                        console.Write(e);
                        break;
                    case "f":
                        console.Write(f);
                        break;
                    case "g":
                        console.Write(g);
                        break;
                    case "h":
                        console.Write(h);
                        break;
                    case "i":
                        console.Write(i);
                        break;
                    case "j":
                        console.Write(j);
                        break;
                    case "k":
                        console.Write(k);
                        break;
                    case "l":
                        console.Write(l);
                        break;
                    case "m":
                        console.Write(m);
                        break;
                    case "n":
                        console.Write(n);
                        break;
                    case "o":
                        console.Write(o);
                        break;
                    case "p":
                        console.Write(p);
                        break;
                    case "q":
                        console.Write(q);
                        break;
                    case "r":
                        console.Write(r);
                        break;
                    case "s":
                        console.Write(s);
                        break;
                    case "t":
                        console.Write(t);
                        break;
                    case "u":
                        console.Write(u);
                        break;
                    case "v":
                        console.Write(v);
                        break;
                    case "w":
                        console.Write(w);
                        break;
                    case "x":
                        console.Write(x);
                        break;
                    case "y":
                        console.Write(y);
                        break;
                    case "z":
                        console.Write(z);
                        break;
                    case " ":
                        console.Write(" ");
                        break;
                    case "1":
                        console.Write(one);
                        break;
                    case "2":
                        console.Write(two);
                        break;
                    case "3":
                        console.Write(three);
                        break;
                    case "4":
                        console.Write(four);
                        break;
                    case "5":
                        console.Write(five);
                        break;
                    case "6":
                        console.Write(six);
                        break;
                    case "7":
                        console.Write(seven);
                        break;
                    case "8":
                        console.Write(eight);
                        break;
                    case "9":
                        console.Write(nine);
                        break;
                    default:
                        console.Write(zero);
                        break;
                }
            }
        }
    }
}