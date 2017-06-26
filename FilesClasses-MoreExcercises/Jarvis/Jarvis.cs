namespace Jarvis
{
    using System;
    using System.Linq;

    /// <summary>
    /// Every kid’s dream is to have its own personal robot to be their butler and/or slave.
    /// Until now, we could not build a fully functional robot, but we can write a program,
    /// which simulates what it would be like to build. Let’s call him a code name – Jarvis.
    ///     Our robot will consist of 6 components – 2 arms, 2 legs, torso and a head.Make 
    ///     classes for these components and your robot should have fields for each of the components. 
    /// Each component has different properties:
    /// •	Arms have:
    /// o Energy consumption (integer)
    /// o Arm reach distance (integer)
    /// o Count of fingers (integer)
    /// •	Legs have:
    /// o Energy consumption (integer)
    /// o Strength (integer)
    /// o Speed (integer)
    ///     •	Torso has:
    /// o Energy consumption (integer)
    /// o Processor size in centimeters (double)
    /// o Housing material (string)
    /// •	Head has:
    /// o Energy consumption (integer)
    /// o IQ (integer)
    /// o Skin material (string)
    /// On the first line, you will receive the maximum energy capacity of the robot.
    /// Until you receive the command “Assemble!”, you will continuously receive lines with data for different components in format:
    /// { typeOfComponent
    /// } {energyConsumption
    /// } {property1} {property2}
    /// The properties will always be given in the same order as they are described above.
    /// If you receive a component which is more energy efficient than previous 
    /// one – you should delete the old component and replace it with the new one.When
    /// both of the components consume more energy than the one, which you try to add  remove the one, which is added first.
    /// Input
    /// •	On the first line, you will receive the maximum energy capacity of the robot.
    /// •	Until you receive the command “Assemble!” you will receive components in the format:
    /// { typeOfComponent
    /// } {energyConsumption} {property1} {property2}
    /// Output
    /// •	If you do not have enough energy efficient components to assemble the robot print:
    /// “We need more power!”
    /// •	If you do not have enough parts print:
    /// “We need more parts!”
    /// •	If you can build a robot with the given components print:
    /// Jarvis:
    /// #Head:
    /// ###Energy consumption: {head’s energy consumption}
    /// ###IQ: {head’s IQ}
    /// ###Skin material: {head’s skin material}
    /// #Torso:
    /// ###Energy consumption: {torso’s energy consumption}
    /// ###Processor size: {size of the processor}
    /// ###Corpus material: {torso’s corpus material}
    /// #Arm:
    /// ###Energy consumption: {arm’s energy consumption}
    /// ###Reach: {arm’s reach}
    /// ###Fingers: {count of fingers}
    /// #Arm:
    /// ###Energy consumption: {arm’s energy consumption}
    /// ###Reach: {arm’s reach}
    /// ###Fingers: {count of fingers}
    /// #Leg:
    /// ###Energy consumption: {head’s energy consumption}
    /// ###Strength: {leg’s strength}
    /// ###Speed: {leg’s speed}
    /// #Leg:
    /// ###Energy consumption: {head’s energy consumption}
    /// ###Strength: {leg’s strength}
    /// ###Speed: {leg’s speed}
    /// Print the legs and the feet ordered by energy consumption in ascending order.
    /// </summary>
    public class Jarvis
    {
        public static void Main()
        {
            Arm[] arms = new Arm[2];
            Leg[] legs = new Leg[2];
            Torso torso = null;
            Head head = null;

            long jarvisEnergy = long.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Assemble!")
            {
                bool legZeroIsFirst = true;
                bool armZeroIsFirst = true;
                string[] parameters = input.Split();

                switch (parameters[0])
                {
                    case "Head":
                        Head currentHead = new Head(int.Parse(parameters[1]), int.Parse(parameters[2]), parameters[3]);
                        if (head == null || currentHead.EnergyConsumption < head.EnergyConsumption)
                        {
                            head = currentHead;
                        }

                        break;

                    case "Torso":
                        Torso currentTorso = new Torso(int.Parse(parameters[1]), double.Parse(parameters[2]), parameters[3]);
                        if (torso == null || currentTorso.EnergyConsumption < torso.EnergyConsumption)
                        {
                            torso = currentTorso;
                        }

                        break;

                    case "Leg":
                        Leg currentLeg = new Leg(int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
                        if (legs[0] == null && legs[1] == null)
                        {
                            legs[0] = currentLeg;
                        }
                        else if (legs[1] == null)
                        {
                            legs[1] = currentLeg;
                        }
                        else if (currentLeg.EnergyConsumption < legs[0].EnergyConsumption && currentLeg.EnergyConsumption < legs[1].EnergyConsumption)
                        {
                            if (legZeroIsFirst)
                            {
                                legs[0] = currentLeg;
                                legZeroIsFirst = false;
                            }
                            else
                            {
                                legs[1] = currentLeg;
                                legZeroIsFirst = true;
                            }
                        }
                        else if (currentLeg.EnergyConsumption < legs[0].EnergyConsumption)
                        {
                            legs[0] = currentLeg;
                        }
                        else if (currentLeg.EnergyConsumption < legs[1].EnergyConsumption)
                        {
                            legs[1] = currentLeg;
                        }

                        break;

                    case "Arm":
                        Arm currentArm = new Arm(int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
                        if (arms[0] == null && arms[1] == null)
                        {
                            arms[0] = currentArm;
                        }
                        else if (arms[1] == null)
                        {
                            arms[1] = currentArm;
                        }
                        else if (currentArm.EnergyConsumption < arms[0].EnergyConsumption && currentArm.EnergyConsumption < arms[1].EnergyConsumption)
                        {
                            if (armZeroIsFirst)
                            {
                                arms[0] = currentArm;
                                armZeroIsFirst = false;
                            }
                            else
                            {
                                arms[1] = currentArm;
                                armZeroIsFirst = true;
                            }
                        }
                        else if (currentArm.EnergyConsumption < arms[0].EnergyConsumption)
                        {
                            arms[0] = currentArm;
                        }
                        else if (currentArm.EnergyConsumption < arms[1].EnergyConsumption)
                        {
                            arms[1] = currentArm;
                        }
                        break;
                }
            }

            if (head == null ||
                torso == null ||
                legs[0] == null ||
                legs[1] == null ||
                arms[0] == null ||
                arms[1] == null)
            {
                Console.WriteLine("We need more parts!");
                return;
            }

            if ((head.EnergyConsumption
                + torso.EnergyConsumption
                + legs[0].EnergyConsumption
                + legs[1].EnergyConsumption
                + arms[0].EnergyConsumption
                + arms[1].EnergyConsumption) > jarvisEnergy)
            {
                Console.WriteLine("We need more power!");
                return;
            }

            arms = arms.OrderBy(x => x.EnergyConsumption).ToArray();
            legs = legs.OrderBy(x => x.EnergyConsumption).ToArray();

            Console.WriteLine($"Jarvis:");
            Console.WriteLine($"#Head:");
            Console.WriteLine($"###Energy consumption: {head.EnergyConsumption}");
            Console.WriteLine($"###IQ: {head.IQ}");
            Console.WriteLine($"###Skin material: {head.SkinMaterial}");
            Console.WriteLine($"#Torso:");
            Console.WriteLine($"###Energy consumption: {torso.EnergyConsumption}");
            Console.WriteLine($"###Processor size: {torso.ProcessorSize:f1}");
            Console.WriteLine($"###Corpus material: {torso.HousingMaterial}");
            Console.WriteLine($"#Arm:");
            Console.WriteLine($"###Energy consumption: {arms[0].EnergyConsumption}");
            Console.WriteLine($"###Reach: {arms[0].Reach}");
            Console.WriteLine($"###Fingers: {arms[0].FingersCount}");
            Console.WriteLine($"#Arm:");
            Console.WriteLine($"###Energy consumption: {arms[1].EnergyConsumption}");
            Console.WriteLine($"###Reach: {arms[1].Reach}");
            Console.WriteLine($"###Fingers: {arms[1].FingersCount}");
            Console.WriteLine($"#Leg:");
            Console.WriteLine($"###Energy consumption: {legs[0].EnergyConsumption}");
            Console.WriteLine($"###Strength: {legs[0].Strength}");
            Console.WriteLine($"###Speed: {legs[0].Speed}");
            Console.WriteLine($"#Leg:");
            Console.WriteLine($"###Energy consumption: {legs[1].EnergyConsumption}");
            Console.WriteLine($"###Strength: {legs[1].Strength}");
            Console.WriteLine($"###Speed: {legs[1].Speed}");
        }
    }
}