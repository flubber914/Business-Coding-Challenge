using Patient_Outreach_Engine;

Database outreachDatabase = new Database();
outreachDatabase.PrintDataBase();
Communicator communicator = new Communicator();
Dispatcher dispatch = new Dispatcher(communicator);
Validator validator = new Validator(dispatch);

validator.ValidateTable(outreachDatabase.GetData());
