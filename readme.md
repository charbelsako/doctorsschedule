# Project Requirements

> Download latest versions.

1. XAMPP [Download Xampp](https://apachefriends.org/download.html)
2. Mysql Connector [Download Connector](https://dev.mysql.com/downloads/connector/)
3. .NET Framework version 4.7.2

Steps to run project
- install the mysql connector should be version 8.x 
- run mysql and start apache and mysql
- open the project in visual studio
- start project
- if project doesn't connect to the data base
- add a reference to mysql.data from the references 
- Rerun project

## Visual Studio Problems

Connecting to the database
The problem turned out to be the version of the .NET framework. Had to download a newer version.

Couldn't figure out how to display the result of the query to the user.
Made a **MySqlDataAdapter**

`MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);`  
Fill the dataset with the data  
`adapter.Fill(ds, "data");`  
Then I return the data from the dataset.  
`return ds.Tables["data"]`  
and store that in a **DataTable** object  
`DataTable table`
and now you can modify the **DataSource** of a **DataGridView** and display the data.  
`dataGridView1.DataSource = table`

When a window other than the main window closes the program keeps running.
To solve this I had to add the line
`Application.Exit()`
in the **FormClosed** event on the other forms

## Database problems

- Because I was stupid enough to make one table for all users. Professor availability is hard to implement. So we didn't implement it.

- Because of the latter complication, we have two unforeseen constraints.
  1. the user has to be of type 'b' (Professor) to exist in the professor absence table and to teach a course.
  2. the user has to be of type 'a' (Student) to register in a course.

## Questions

1. If I have an intermediary table are both foreign keys primary? If so how do I determine that?
2. Am i an idiot?

## Other titles
