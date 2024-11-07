(Standard numeric format)

int X = 10;
int Y = 20;
Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");


in one (1) pdf page:
1. why the output of this Equation = $30.00?
2. what is its benefit?
3. try another example with a different specifier with a screenshot of the output.

   الاجابات:
   1. عشان الغانكشن المكتوبة في 5 سطر بيجمع x و y و الكود: {X + Y:C} عرف ان الرقم ده عملة فا بالتالي حط جمبها ال $ 
   2. ان ال standard numeric format بيعرف الارقام زي ال عملة او النسبة فا بالتالي ممكن نعرفه ان دي عملة من غير ما نحط ال$ في ال Console.WriteLine
   3. int X = 20;
      int Y = 10;
      Console.WriteLine($"Equation: {X} / {Y} = {X / Y:F2}");
      Output: Equation: 20 / 10 = 2.00
