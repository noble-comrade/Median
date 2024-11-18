MedianFinder median = new MedianFinder();
median.addNum(1);
median.addNum(5);
median.addNum(2);
Console.WriteLine(median.findMedian());
median.addNum(4);
Console.WriteLine(median.findMedian());
class MedianFinder 
{
    List<int> Array = [];
    public void addNum(int num) => Array.Add(num);
    public double findMedian() 
    {
        Array.Sort();
        if (Array.Count()%2 == 0) 
        {
            int i = Array.Count() / 2;
            double j = (Array[i] + Array[i - 1]) / 2;
            return j;
        }
        else 
        {
            int i = Array.Count() / 2;
            int j = Array[i];
            return j;
        }
    }
}