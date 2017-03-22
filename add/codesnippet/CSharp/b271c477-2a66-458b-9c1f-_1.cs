      string dateString;
      DateTimeOffset offsetDate;

      dateString = "05/01/2008 6:00:00";
      // Assume time is local 
      offsetDate = DateTimeOffset.Parse(dateString, null, DateTimeStyles.AssumeLocal);
      Console.WriteLine(offsetDate.ToString());   // Displays 5/1/2008 6:00:00 AM -07:00

      // Assume time is UTC
      offsetDate = DateTimeOffset.Parse(dateString, null, DateTimeStyles.AssumeUniversal);
      Console.WriteLine(offsetDate.ToString());   // Displays 5/1/2008 6:00:00 AM +00:00

      // Parse and convert to UTC 
      dateString = "05/01/2008 6:00:00AM +5:00";
      offsetDate = DateTimeOffset.Parse(dateString, null, DateTimeStyles.AdjustToUniversal);
      Console.WriteLine(offsetDate.ToString());   // Displays 5/1/2008 1:00:00 AM +00:00