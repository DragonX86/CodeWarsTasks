static int Past(int h = 0, int m = 0, int s = 0)
{
    var hours = !(h < 0 || h >= 24) ? h : 0;
    var minutes = !(m < 0 || m >= 60) ? m : 0;
    var seconds = !(s < 0 || s >= 60) ? s : 0;

    var result = 1000 * (hours * 60 * 60 + minutes * 60 + seconds);
    
    return result;
}

Console.WriteLine(Past(7,17,44));