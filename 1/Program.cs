//Написать программу, которая обменивает элементы первой строки и последней строки
public override void Execute()
        {
            var n = Utility.ReadIntConsole("Введите кол-во строк");
            var m = Utility.ReadIntConsole("Введите кол-во столбцов");

            var matrix = Utility.CreateMatrix(n, m);
            Execute(matrix);

            var r1 = Utility.ReadIntConsole("Введите номер строки 1") - 1;
            var r2 = Utility.ReadIntConsole("Введите номер строки 2") - 1;

            Utility.SwapRows(ref matrix, r1, r2);
            Execute(matrix);
        }

        override public string GetName()
        {
            return "Написать программу, которая обменивает элементы заданных строк.";
        }
    