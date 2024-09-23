class Mbti {
  public static void Main (string[] args) {

    // questions 
    string[] quiz = {
      "1. I prefer to be alone \n2. I gain energy from social gathering",
      "3. I'm more imaginative \n4. I trust hard facts",
      "5. I need to include others' when making decision \n6. I like to make decision based on logical thinking",
      "7. I'm flexible and adaptable \n8. I like to make plans and follow through"
    };

    // assigned asnwers
    string r = "Introvert";
    string e = "Extrovert";
    string v = "Intuitive";
    string s = "Sensing";
    string f = "Feeling";
    string t = "Thinking";
    string p = "Perceiving";
    string j = "Judging";

    // questions displayed
    Console.WriteLine("MBTI Quick Personality Test");
    for (int i=0; i < quiz.Length; i++) {
      Console.WriteLine("Question");
      Console.WriteLine(quiz[i]);
      Console.Write("Please enter your answer ");
      string answer = Console.ReadLine();

      // verify each answer
      if (string.Equals(answer, "1", StringComparison.OrdinalIgnoreCase)) {
        Console.WriteLine(r);
      }
      else if (string.Equals(answer, "2", StringComparison.OrdinalIgnoreCase)) {
        Console.WriteLine(e);
      }
      else if (string.Equals(answer, "3", StringComparison.OrdinalIgnoreCase)) {
        Console.WriteLine(v);
      }
      else if (string.Equals(answer, "4", StringComparison.OrdinalIgnoreCase)) {
        Console.WriteLine(s);
      }
      else if (string.Equals(answer, "5", StringComparison.OrdinalIgnoreCase)) {
        Console.WriteLine(f);
      }
      else if (string.Equals(answer, "6", StringComparison.OrdinalIgnoreCase)) {
        Console.WriteLine(t);
      }
      else if (string.Equals(answer, "7", StringComparison.OrdinalIgnoreCase)) {
        Console.WriteLine(p);
      }
      else if (string.Equals(answer, "8", StringComparison.OrdinalIgnoreCase)) {
        Console.WriteLine(j);
      } 
    }

    Console.WriteLine("MBTI Personality Test Completed!");

  }
}