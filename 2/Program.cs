//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
 public override void Execute()
        {
            var n = Utility.ReadIntConsole("Введите кол-во строк");
            var m = Utility.ReadIntConsole("Введите кол-во столбцов");

            var matrix = Utility.CreateMatrix(n, m);
            Utility.DisplayArr(matrix);

            //ascending
            matrix.SortElementsRows();
            Utility.DisplayArr(matrix);

            //descending
            matrix.SortElementsRows(true);
            Utility.DisplayArr(matrix);
        }

        public override string GetName()
        {
            return "Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.";
        }
