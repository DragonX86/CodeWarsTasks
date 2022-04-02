/*
 * TODO:
 * You get an array of numbers, return the sum of all of the positives ones.
 */

static int PositiveSum(int[] arr)
{
    return arr.Where(n => n > 0).Sum();
}