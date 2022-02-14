namespace Candidate_Ex4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidate per1 = new Candidate();
            per1.Name = "林來來";
            Console.WriteLine("候選人姓名:{0}", per1.Name);
            Console.WriteLine("第 {0} 號登記", Candidate.Num);
            Console.WriteLine("----------------------------");
            Candidate per2 = new Candidate();
            per2.Name = "蔡小小";
            Console.WriteLine("候選人姓名:{0}", per2.Name);
            Console.WriteLine("第 {0} 號登記", Candidate.Num);
            Console.WriteLine("----------------------------");
            Console.WriteLine("目前登記總人數:{0}人", Candidate.Num);
            Console.Read();
        }
    }
}