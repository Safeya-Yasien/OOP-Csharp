using System;
// namespace Task2
// {
    class Students
    {
        int id;
        string name;
        int total;
        string eval;

        // constructor
        public Students()
        {
            id = total = 0;
            name = eval = "";
        }

        // constructor
        public Students(int id, string name, int total)
        {
            this.id = id;
            this.name = name;
            this.total = total;
        }

        public int ID
        {
            set {id = value;}
            get {return (id);}
        }

        public string Name
        {
            set {name = value;}
            get {return (name);}
        }

        public string Eval
        {
            set {eval = value;}
        }        

        public void CalcEval()
        {
            if (total >= 85 && total <= 100)
            {
                eval = "Excellent";
            }
            else if (total >= 75 && total < 85)
            {
                eval = "Very Good";
            }
            else if (total < 50)
            {
                eval = "Failed";
            }
            else
            {
                eval = "Passed";
            }
        }

        public string PrintData()
        {
            string data = $"ID: {id}\nName: {name}\nTotal: {total}\nEvaluation: {eval}\n";
            Console.WriteLine(data);
            return (data);

            // or
            // return ("ID: " + id + "\n" + "Na\nme: " + name + "\n" + "Total: " + total + "\n" + "Evaluation: " + eval + "");

        }
    }
// }