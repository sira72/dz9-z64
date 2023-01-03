// задача 64. Задайте значение М и N. Напишитепрограмму, которая выведетвсе натуральные числа от M до  N.
// M=1; N=5. -> " " 1,2,3,4,5" "
// M=4; N=8. -> " "4,6,7,8" "

object NaturalNumbers(int n, int m)
{
    if (n<=m) return $"{n} + NaturalNumbers (n+1,m)";
    else return String.Empty ;
}
