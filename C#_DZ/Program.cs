using C__DZ.DZ_14_05_25.Mappers;


var instructionByNameProcedure = MapperCode.MapProcedurs(@"
    sub main
    set a 1
    call foo
    print a
    sub foo
    set a 2
");