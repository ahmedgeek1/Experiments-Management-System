Application that will allow a student to store data from multiple attempts at a science project.  Your app will give the student a way to enter data from the experiments and a way to choose a previously stored experiment and display that data on a second screen (form).

Create a Class called ‘Experiment’.  Using the method that creates a separate file/listing in the Visual Studio Solution Explorer is much preferred, but I will take any valid class via either of the ways Visual Studio and C# allow.  The Experiment needs to hold the data shown below.  Set up the appropriate Fields for:

Student Name
Experiment Number (1-50)
Experiment Description (no more than 500 characters)
Result Weight (numbers with a fractional part like 6.78)
Result Color (allow only Crimson, Azure, Taupe, Mauve, Vermillion, and Chartreuse)
Result Volume (numbers with fractional portions like 567.32)

Ensure that the Fields are set to Private and that they all have the appropriate Public Property created so that data can be entered and retrieved.  You will also need to set up multiple (Overloaded) Constructors that allow various parameters to be passed when creating the object because the student does not always know all the data when he or she is working with your app.  Give the student the following three options (Constructors) to create an Experiment:

Nothing is known
Only the Student Name is known
Only the Experiment Number and Experiment Description are known
Design a Form with the appropriate controls and a ‘Create’ Button to allow the student to use any of the Constructors listed to ‘Create’ his or her Experiment in memory as an instantiated Experiment object called ‘exp’.  Use an appropriate decision making structure (If-Elseif-Else statement) to navigate to the correctly worded instantiation code to bind to the appropriate Constructor.

Through additional controls, allow the student, *after* they have created the experiment with the step above, to fill in the rest of the data fields or change any data already entered.  The student will then press a ‘Set’ Button to add that data to the ‘exp’ Experiment object in memory.

The student will want to create multiple Experiments, so the final action for the current Experiment will be to press a ‘Save’ Button that will add the current ‘exp’ Experiment object to an Array called ‘Experiments’ for storage now and retrieval later.  It will save the Experiment to the element of the array that has an index/subscript that matches the Experiment Number.  At the point of the ‘Save’ click, your app will also add the Experiment Number and Experiment Description as one line (two columns separated by a tab (‘\t’)) to a ListBox on the Form as a summary of experiments saved so far.

The student will be allowed to repeat the three steps above (Create, Set, Save) for up to 50 Experiments.  They can add Experiments in any order they want (they might add Experiment 14 first, then 1, 2, and 3, then 39, followed by 27.).  Each time they can use any of the Constructors, and each time, when saved, the experiment will be stored in the array (where the array index matches the Experiment Number) and the summary data will be added to the ListBox.

If the student tries to overwrite an existing Experiment in the array by using the same Experiment Number a second time, ask them if that is what they really want to do.  If they do, overwrite it, if they don’t, go back and allow them to choose (and set) a different experiment number. Do not allow the student to enter more experiments than the array can hold – once full, disable the controls in the Create, Set, and Save areas.

As the Experiment is ‘Created’ and additional data is ‘Set’, any filled field must have data appropriate to the field, but any field can be left empty.  The student can change data, add data, or remove data, and then ‘Set’ that data to the ‘exp’ object as many times as they want.  However, *all* fields must be filled to allow the ‘Save’.  If the experiment data is incomplete, no save is allowed.  Also, the ‘Save’ process does not retrieve any data from the form controls, that is the job of ‘Set’.  The ‘Save’ *only* places the ‘exp’ Experiment object into the array in the proper spot and adds the summary data to the ListBox.

The last feature of the application is that the student can retrieve any previous experiment and view the data.  For this, set it up so that when the student double-clicks on an experiment in the summary ListBox, a second form called ‘Review’ pops up showing all the data for that Experiment.  The Review form will take control and not allow the user to return to the Data Entry form until the Review form is closed.  Also, the data on the Review form will not be editable. – it is for review only. Allow this review process to occur at any time without affecting the current Experiment, even if it is incomplete and unsaved.  When the review is done, the user can go right back to where they left off and finish the Experiment they were working on previously.

Data Validation is extremely important here because a number of things can go wrong.  At any point where there is a user error or bad/missing data in the process, the process should stop and an appropriate (helpful) error message should display to the user.  Make sure there are the usual ‘Clear’ and ‘Exit’ options.
