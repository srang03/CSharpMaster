namespace ReadBytes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Ian\Desktop\android_new";
            var fileName = "1a4258348a001b886b93cddffe5ce9b25d7f64debd3469157de8792519039323.jpg";
            using (var fs = new FileStream(Path.Combine(path, fileName), FileMode.Open, FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                byte[] buffer = br.ReadBytes(4);
                var temp = BitConverter.ToString(buffer);
                fs.Close();
            }
        }
    }
}