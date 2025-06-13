using C__DZ.DZ_14_05_25.Model;

namespace C__DZ.DZ_14_05_25.Mappers;

public class MapperCode
{
    public static Dictionary<string, Queue<InstructionDto>> MapProcedurs(string code)
    {
        var instructions = MapInstructions(code);
        var instructionsByNameProcedure = new Dictionary<string, Queue<InstructionDto>>();

        var currentProcedureName = string.Empty;
        for (int i = 0; i < instructions.Count; i++)
        {
            var instruction = instructions[i];
            var instructionArguments = instruction.TextInstruction.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            if (instructionArguments.Contains("sub"))
            {
                currentProcedureName = instructionArguments[1];
                instructionsByNameProcedure[currentProcedureName] = [];
            }
            else
            {
                instructionsByNameProcedure[currentProcedureName].Enqueue(instruction);
            }
        }

        return instructionsByNameProcedure;
    }
    private static List<InstructionDto> MapInstructions(string code)
    {
        var instructions = new List<InstructionDto>();
        var instructionLines =  code.Split(["\r\n", "\n"], StringSplitOptions.None);

        for (int i = 0; i < instructionLines.Length; i++)
        {
            if (instructionLines[i] == string.Empty)
            {
                continue;
            }

            var instructionDto = new InstructionDto()
            {
                TextInstruction = instructionLines[i],
                NumberInstruction = i
            };

            instructions.Add(instructionDto);
        }

        return instructions;
    }
}
