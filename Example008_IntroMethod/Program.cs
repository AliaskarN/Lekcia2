int Max(int arg1, int arg2, int arg3) //Вводим массивы для каждого 
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; //Возвращаем result
}

int a1 = 4;
int b1 = 47;
int c1 = 632;
int a2 = 45465249;
int b2 = 547;
int c2 = 32;
int a3 = 478;
int b3 = 247;
int c3 = 66532;

// int max1 = Max(a1, b1, c1);            //Все аргументы выявляем по отдельности промежуточные результаты
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);