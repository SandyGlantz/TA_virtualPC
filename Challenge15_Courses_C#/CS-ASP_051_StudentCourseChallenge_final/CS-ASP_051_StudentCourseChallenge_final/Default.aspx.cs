﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_051_StudentCourseChallenge_final
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
// ========================   Code Notes   ========================
            /*
             * Typically prefer scrunched code, but on this project
             * the code is spread out to keep track of all the "{" and "}"
             * 
             * Added a version two (v.2) on the second button/assignment.
             * Original only used Collection Initializer.
             * Requirement was to use Collection AND Object Initializer.
            */
        }





// ========================   BUTTON 1   ========================

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /* 
            * Challenge Requirements:
            * 
            * Create a List of three Courses.
            * Each Course should have at least two Students enrolled.
            * Use Object and Collection Initializers.
            * Iterate through each Course and print out the:
            * Course details 
            * and the Students that are enrolled in each Course.
            * 
            * NOTE: !!
            * 
            * Stated Challenge criteria is to use Object *AND* Collection Initializers
            * NOT used in instructor's solution - so leaving mine as is ...
            * Just used Collection (and a collection within a collection at that!)
            *  
            */

            // cosmetics ...
            resultLabel.Text = "<hr><br/>";


            // Collection initialization
            // List<Course> courses = new List<Course>() --> replaced w/var 

            var courses = new List<Course>()
            
            {
                new Course
                { CourseId = 101, Name="Claw Sharpening",
                    Students = new List<Student>()
                    {
                        new Student()
                            { StudentId = 1010, Name = "Mittens" },
                        new Student()
                            { StudentId = 1011, Name = "Tom" }
                    }
                },

                new Course
                { CourseId = 102, Name="Catnip Tasting",
                    Students = new List<Student>()
                    {
                        new Student() { StudentId = 1012, Name = "Whiskers" },
                        new Student() { StudentId = 1014, Name = "Kitty-Girl" }
                    }
                },

                new Course
                { CourseId = 103, Name="Quality Naps",
                    Students = new List<Student>()
                    {
                        new Student() { StudentId = 1015, Name = "Boots" },
                        new Student() { StudentId = 1016, Name = "BobCat" }
                    }
                }
            }; //end List<>


            // purposefully changed the look - but included all required values.           
            // foreach (Course course in courses)

            foreach (var course in courses)
            {
                resultLabel.Text += string.Format
                    ("<br/><br/><b>Course: {0}</b> (course ID: {1})", 
                    course.Name, course.CourseId);

                // foreach inside of a foreach ...
                // foreach (Student student in course.Students)

                foreach (var student in course.Students)
                {
                    resultLabel.Text += string.Format
                        ("<br/>&nbsp&nbsp Student: {0} (student ID: {1})", 
                        student.Name, student.StudentId);
                }
            }

            resultLabel.Text += "<br/><br/>";

        }








// ========================   BUTTON 2 -- Original Version   ========================

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
            * Create a Dictionary of three Students.
            * Use the StudentId as the key.
            * Each student must be enrolled in two Courses.
            * Use Object and Collection Initializers.   
            * Iterate through each student and print out to the web page:
            * each Student's info -- and the Courses the Student is enrolled in.
            */


            // cosmetics ...
            resultLabel.Text = "<hr><br/><br/>";


            // Collection initialization
            // Dictionary<int, Student>

            var students = new Dictionary<int, Student>()
            {
                {1020, new Student()
                {StudentId= 1020, Name= "Morris",
                    Courses = new List<Course>()
                        {new Course() {CourseId= 104, Name= "Advanced Hairball-ology"},
                        {new Course() {CourseId= 105, Name= "Eliminating Canine Threats"}
                        }
                        }
                }
                },

                {1021, new Student()
                {StudentId= 1021, Name= "Grumpy Cat",
                        Courses = new List<Course>()
                            {new Course() {CourseId= 106, Name= "Strategic Hisses"},
                            {new Course() {CourseId= 107, Name= "Hiding From Humans"}
                            }
                            }
                }
                },


                {1022, new Student()
                {StudentId= 1022, Name= "Simon's Cat",
                        Courses = new List<Course>()
                            {new Course() {CourseId= 108, Name= "Food Is Love"},
                            {new Course() {CourseId= 109, Name= "Successful Feeding Strategies"}
                            }
                            }
                }
                }
            }; //end Dictionary<>


            // purposefully changed the look - but included all required values.
            // foreach (KeyValuePair<int, Student> student in students)
            foreach (var student in students)
            {
                resultLabel.Text += string.Format
                    ("<br/><b>Student: {0}</b> (student ID: {1})<br/>",
                    student.Value.Name, student.Value.StudentId);

                // foreach (Course course in student.Value.Courses)
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += string.Format
                        ("&nbsp&nbsp Course: {0} (course ID: {1})<br/>",
                        course.Name, course.CourseId);
                }
            }

            resultLabel.Text += "<br/><br/>";

        }



// ========================   BUTTON 2 -- Version 2   ========================

        protected void assignment2v2Button_Click(object sender, EventArgs e)
        {
            /*
            * Create a Dictionary of three Students.
            * Use the StudentId as the key.
            * Each student must be enrolled in two Courses.
            * ==> Use Object ***and*** Collection Initializers.   
            * Iterate through each student and print out to the web page:
            * each Student's info -- and the Courses the Student is enrolled in.
            */


            // cosmetics ...
            resultLabel.Text = "<hr><br/><br/>";


            // *Object* Initialization  
            // Above (v.1) uses only Collection Initializers 
            // That put courses directly into the Student class, Courses<> prop

            // List<Course> course = new List<Course>();
            var course = new List<Course>();
            course.Add(new Course { CourseId = 117, Name = "Territory Marking for Success" });
            course.Add(new Course { CourseId = 118, Name = "Professional Collar Escapes" });
            course.Add(new Course { CourseId = 119, Name = "Overcoming Physics of Falling" });


            //Dictionary<int, Student> students = new Dictionary<int, Student>()
            var students = new Dictionary<int, Student>()
            {
                {
                    1041, new Student
                    { StudentId = 1041, Name = "Misty",
                        Courses = new List<Course>
                        { course.ElementAt(0), course.ElementAt(1)}
                    }
                },


                {1042, new Student
                    { StudentId = 1042, Name = "FurBall",
                        Courses = new List<Course>
                        { course.ElementAt(1), course.ElementAt(2)}
                    }
                },


                { 1043, new Student
                    { StudentId = 1043, Name = "Mr. Whiskers",
                        Courses = new List<Course>
                        { course.ElementAt(2), course.ElementAt(0)}
                    }
                }
            }; // end Dictionary<>


            // ?? why is var this format:
            // foreach (KeyValuePair<int, Student> student in students)
            foreach (var student in students)
            {
                resultLabel.Text += string.Format
                    ("<br/><b>Student: {0}</b> (student ID: {1})<br/>", 
                    student.Value.Name, student.Value.StudentId);

                //foreach (Course courses in student.Value.Courses)
                foreach (var courses in student.Value.Courses)
                {
                    resultLabel.Text += string.Format
                        ("&nbsp&nbsp Course: {0} (course ID: {1})<br/>", 
                        courses.Name, courses.CourseId);
                }
            }

            resultLabel.Text += "<br/><br/>";

        }




// ========================   BUTTON 2 -- Version 3   ========================

        protected void assignment2v3Button_Click(object sender, EventArgs e)
        {
            // See requirements in earlier versions
            // This is the solution approach from the Instructor
            // Better code - but ?? misses requirement of List Object Initialization 
            // ... or ... is this "just" object initialization without the list, see:
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer 


            resultLabel.Text = "<hr><br/><br/>";


            // creates three courses for reuse across student dictionary...

            Course indoorScratching = new Course()
            { CourseId = 120, Name = "Indoor Scratching Selection" };

            Course kittenWeaning = new Course()
            { CourseId = 121, Name = "Kitten Development Post Weaning" };

            Course advancedPlay = new Course()
            { CourseId = 122, Name = "Advanced Strategies for String Play" };


            // and the Dictionary of Students ...
            // Dictionary<int, Student> students = new Dictionary<int, Student>()

            var students = new Dictionary<int, Student>()
            {
                {1, new Student
                {
                    StudentId = 1051, Name = "Felix",
                    Courses = new List<Course> {indoorScratching, advancedPlay }
                } },

                // note the int can be anything "{*1*, new Student "
                //     - EXCEPT not duplicated
                // int shown here as 1, 2, and 3 does not have to match the course
                // like in SQL - it's just a unique key
                // keeping it the course number would allow for better searching though ...

                {2, new Student
                {
                    StudentId = 1052, Name = "Shadow",
                    Courses = new List<Course> {indoorScratching, kittenWeaning }
                } },

                {3, new Student
                {
                    StudentId = 1053, Name = "Baby",
                    Courses = new List<Course> {kittenWeaning, advancedPlay }
                } }
            }; // end Dictionary


            // foreach (KeyValuePair<int, Student> student in students)
            foreach (var student in students)
            {
                resultLabel.Text += string.Format
                    ("<br/><b>Student: {0}</b> (student ID: {1})<br/>",
                    student.Value.Name, student.Value.StudentId);

                //foreach (Course courses in student.Value.Courses)
                foreach (var courses in student.Value.Courses)
                {
                    resultLabel.Text += string.Format
                        ("&nbsp&nbsp Course: {0} (course ID: {1})<br/>",
                        courses.Name, courses.CourseId);
                }

            };

                resultLabel.Text += "<br/><br/>";

        }







// ========================   BUTTON 3   ========================

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * Keep track of three Student's grades (0 to 100) -- in two Courses.
             * 
             * This means at a minimum, you'll need to add another class, 
             * and probably need to modify the existing classes to accommodate this. 
             * 
             * Give each Student a grade in each Course they are enrolled in.
             * Iterate through each student and print out to the web page:
             *  each Course they are enrolled in -- and the grade.
             */



        // cosmetics ...
        resultLabel.Text = "<hr><br/>";


            // List<Student> students = new List<Student>()
            var students = new List<Student>()
            {
                new Student()
                {
                    StudentId= 1030, Name= "Tigger", Grades = new List<ReportCard>()
                    {
                        new ReportCard()
                        {
                            Grade= 100, Course= new Course {CourseId= 110, Name= "Jumping Over Barriers"}
                        },
                        new ReportCard()
                        {
                            Grade= 75, Course= new Course {CourseId= 111, Name= "Social Chewing" }
                        }
                    }
                },


                new Student()
                {
                    StudentId= 1031, Name= "Fluffy", Grades = new List<ReportCard>()
                    {
                        new ReportCard()
                        {
                            Grade= 95, Course= new Course {CourseId= 112, Name= "Grooming Basics"}
                        },
                        new ReportCard()
                        {
                            Grade= 90, Course= new Course {CourseId= 114, Name= "Advanced Longhair Grooming Techniques" }
                        }
                    }
                },


                new Student()
                {
                    StudentId= 1032, Name= "Princess", Grades = new List<ReportCard>()
                    {
                        new ReportCard()
                        {
                            Grade= 100, Course= new Course {CourseId= 115, Name= "Taming Human Staff"}
                        },
                        new ReportCard()
                        {
                            Grade= 95, Course= new Course {CourseId= 116, Name= "Advanced Human Management" }
                        }
                    }
                }
            }; // end List<>


            
            // foreach (Student student in students)
            foreach (var student in students)
            {
                resultLabel.Text += string.Format
                    ("<br/><br/><b> Student: {0}</b> (student ID: {1})",
                    student.Name, student.StudentId);

                // foreach (ReportCard grades in student.Grades)
                foreach (var grades in student.Grades)
                {
                    resultLabel.Text += string.Format
                        ("<br>&nbsp&nbsp<b> Grade: {0}</b>, Course: {1}, (Course ID: {2})",
                        grades.Grade, grades.Course.Name, grades.Course.CourseId );
                }
            }

            resultLabel.Text += "<br/><br/>";

        } // end button 3 v1






// ========================   BUTTON 3, Version 2   ========================

        protected void assignment3v2Button_Click(object sender, EventArgs e)
        {
            // See previous for requirements
            // doing second verison for practice


            // cosmetics ...
            resultLabel.Text = "<hr><br/>";



            // create access to class Student properties
            Student student = new Student();


            // create a new student to have the grades
            student.StudentId = 1062;
            student.Name = "Socks";

            // creates the student grades
            student.Grades = new List<ReportCard>()
            {
                new ReportCard
                {
                    Grade = 40, Course = new Course
                    {
                        CourseId = 123, Name="Incentivize Human Staff"
                    }
                },              
                
                new ReportCard
                {
                    Grade = 100, Course = new Course
                    {
                        CourseId = 124, Name = "Drama 101: Expressive Meowing"
                    }
                }               
            }; // end List<>


            resultLabel.Text += string.Format
                ("<br/><br/><b> Student: {0}</b> (student ID: {1})",
                    student.Name, student.StudentId);

            foreach (ReportCard grades in student.Grades)
            {
                resultLabel.Text += string.Format
                        ("<br>&nbsp&nbsp<b> Grade: {0}</b>, Course: {1}, (Course ID: {2})",
                        grades.Grade, grades.Course.Name, grades.Course.CourseId);
            }
            

            resultLabel.Text += "<br/><br/>";

        } // end button 3v2


    } // end Default class
} // end namespace