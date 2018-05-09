using System;
using System.Collections.Generic;
using Helper.External.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_ProcessClass
{
    [TestClass]
    public class ProcessClass_UnitTest
    {
        [TestMethod]
        public void Process_ProcessUserInput()
        {
            // arrange
            
            //USERS
            User test1 = new User();
            test1._focus = "STRENGTH";
            test1._type = "UPPERBODY";
            test1._difficulty = "2";

            //INDIVIDUAL EXERCISES
            Exercises t1 = new Exercises();
            t1.name = "Push up";
            t1.focus = "STRENGTH";
            t1.type = "UPPERBODY";
            t1.description = "Using your arms push up from the ground";

            Exercises t2 = new Exercises();
            t2.name = "Sit up";
            t2.focus = "STRENGTH";
            t2.type = "UPPERBODY";
            t2.description = "lay and raise up";

            Exercises t3 = new Exercises();
            t3.name = "Lunge";
            t3.focus = "STRENGTH";
            t3.type = "UPPERBODY";
            t3.description = "lay and raise up";

            Exercises t4 = new Exercises();
            t4.name = "Sprint";
            t4.focus = "STRENGTH";
            t4.type = "LOWERBODY";
            t4.description = "run";

            Exercises t5 = new Exercises();
            t5.name = "Dog Pose";
            t5.focus = "STRENGTH";
            t5.type = "CORE";
            t5.description = "Contort your body";

            Exercises t6 = new Exercises();
            t6.name = "Cow Pose";
            t6.focus = "FLEXIBILITY";
            t6.type = "UPPERBODY";
            t6.description = "contort it in a different way";

            Exercises t7 = new Exercises();
            t7.name = "Upper Cut";
            t7.focus = "STRENGTH";
            t7.type = "UPPERBODY";
            t7.description = "contort it in a different way";

            Exercises t8 = new Exercises();
            t8.name = "Torso Twist";
            t8.focus = "STRENGTH";
            t8.type = "LOWERBODY";
            t8.description = "rotate at the waist";

            Exercises t9 = new Exercises();
            t9.name = "Wall Push";
            t9.focus = "STRENGTH";
            t9.type = "UPPERBODY";
            t9.description = "Using your arms push up from the ground";

            Exercises t10 = new Exercises();
            t10.name = "dumbell curl";
            t10.focus = "STRENGTH";
            t10.type = "UPPERBODY";
            t10.description = "Using your arms push up from the ground";

            Exercises t11 = new Exercises();
            t11.name = "Lift weights";
            t11.focus = "STRENGTH";
            t11.type = "UPPERBODY";
            t11.description = "Using your arms push up from the ground";

            Exercises t12 = new Exercises();
            t12.name = " Not a Push up";
            t12.focus = "STRENGTH";
            t12.type = "UPPERBODY";
            t12.description = "Using your arms push up from the ground";

            //LIST OF EXERCISES
            List<Exercises> ExerciseList = new List<Exercises>{ t1, t2, t3, t4, t5, t6, t7, t8,t9,t10,t11,t12 };
            List<Exercises> expected = new List<Exercises>();

            // act
            Process p1 = new Process();
            List<Exercises> actual = p1.ProcessUserInput(test1, ExerciseList);

            for (int i = 0; i <6; i++) {
                if (actual[i].name.Equals(ExerciseList[0].name) || actual[i].name.Equals(ExerciseList[1].name) || actual[i].name.Equals(ExerciseList[2].name) ||
                    actual[i].name.Equals(ExerciseList[3].name) || actual[i].name.Equals(ExerciseList[4].name) || actual[i].name.Equals(ExerciseList[5].name) ||
                    actual[i].name.Equals(ExerciseList[6].name) || actual[i].name.Equals(ExerciseList[7].name) || actual[i].name.Equals(ExerciseList[8].name) ||
                    actual[i].name.Equals(ExerciseList[9].name) || actual[i].name.Equals(ExerciseList[10].name) || actual[i].name.Equals(ExerciseList[11].name))
                {
                    expected.Add(actual[i]);

                }
            }


            // assert 
            System.Diagnostics.Debug.Print(actual[0].name + " " + actual[1].name + " " + actual[2].name + " " + actual[3].name + " " + actual[4].name + " " + actual[5].name);
            System.Diagnostics.Debug.Print(expected[0].name + " " + expected[1].name + " " + expected[2].name + " " + expected[3].name + " " + expected[4].name + " " + actual[5].name);

            Assert.IsInstanceOfType(expected,typeof(List<Exercises>));

        }
    }
}
