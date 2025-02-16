using POOConcepts;

try {
    var date1 = new Date();
    var date2 = new Date(1974, 12, 35);
    var date3 = new Date(2019, 12, 3);

    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);

}
catch (Exception ex)
{
    Console.WriteLine(ex);
}