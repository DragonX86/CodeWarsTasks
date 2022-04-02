static int MakeNegative(int number) => number != 0 ? number > 0 ? -number : number : 0;

MakeNegative(-2);
MakeNegative(0);
MakeNegative(5);