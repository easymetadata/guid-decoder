using System;

namespace guid_decode
{
    class Program
    {
        static void Main(string[] args)
        {
            //var originalGuid = new Guid("633af0719ac547e99e7440c5e4d92a2c").:
            //Guid.TryParse("633af071-9ac5-47e9-9e74-40c5e4d92a2c", out originalGuid);

            ///Possible uuid types
            ///Random - useless
            ///Timebased - usefull
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a uuid/guid");
                return;
            }
            //String uuidString = "043e6c68-1cb9-11dc-8b22-d0cf6f8f7ed9";
            String uuidString = args[0];
            Guid gui = new Guid(uuidString);
            DateTime dt = GuidGenerator.GetDateTime(gui);
            //var dt = GuidGenerator.(gui);

            Console.WriteLine(gui.GetVersion().ToString());

            Console.WriteLine(dt.ToString());

            var t = guid_decode.GuidGenerator.GetVersion(gui);
            Console.WriteLine(t.ToString());

            var d = guid_decode.GuidGenerator.GetUtcDateTime(gui);
            Console.WriteLine(d.ToString());

            if (uuidString.Contains("95B"))
                Console.WriteLine("MAC Addr: " + uuidString);
        }
    }
}
