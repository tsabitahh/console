class UvStats {
  public static void Main (string[] args) {
    // input UV Index from 1-11
    Console.WriteLine("Enter a UV index:");
    int uvIndex = Convert.ToInt32(Console.ReadLine());
    // each of the UV Index output
    if (uvIndex <= 2) {Console.WriteLine("Low UV. No protections needed");}
    else if (uvIndex >= 3 && uvIndex <= 5) {Console.WriteLine("Moderate UV. Good for tanning");}
    else if (uvIndex >=6 && uvIndex <= 7) {Console.WriteLine("High UV. Wear sunscreen and other protections");}
    else if (uvIndex >= 8 && uvIndex <= 10) {Console.WriteLine("Very High UV. This UV could potentially cause skin cancer");}
  }
}
