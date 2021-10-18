Test scripts are written in webdriver with C#. In order to run tests visual studio/code is needed.
I have choose data driven approach for tests, since testing registration form requires a lot od test data sets.
The structure is following:
-pageobjects folder contains all elements and actions on page Registration form
-support folder contains class user, which is needed to populate all data required 

 Writting tests should be easy, since it is based on calling proper methods from created classes.

If the architecture is well organised and prepared, QA Engineer should only manipulate with test data and to create tests by calling proper methods.

Based on created pageobject and user class, it is possible to create various number of tests.
Before run, should check testdata folder> RegisterTestData class and update data if needed (email). Reason could be that user already exists.

How to run tests?


1.In the Build menu, choose Build Solution (or press Ctrl + SHIFT + B).
2.If Test Explorer is not open, open it by choosing Test > Windows > Test Explorer from the top menu bar (or press Ctrl + E, T).
3.Choose Run All to run the test (or press Ctrl + R, V) or Run selected test (recommended)
