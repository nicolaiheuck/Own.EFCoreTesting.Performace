using AutoMapper;
using AutoMapper.QueryableExtensions;
using EFCoreTesting.Performace.AutoMapper;

var mapper = new MapperConfiguration(config =>
{
    config.CreateMap<BigDataSet, BigDataSubsetDTO>();
}).CreateMapper();

using BigDataContext context = new();
Console.WriteLine($"Row count: {context.BigDataSets.Count()}");
using (new TimedAction(".Where().Select().ToList()"))
{
    List<BigDataSubsetDTO> list = context.BigDataSets
        .Where(d => d.Guid % 2 == 0)
        .Where(d => d.Guid > 1000)
        .Select(d => new BigDataSubsetDTO
        {
            Id = d.Guid,
            Email = d.Email
        }).ToList();
}
using (new TimedAction(".ToList().Where().Select()"))
{
    List<BigDataSubsetDTO> list2 = context.BigDataSets
        .ToList()
        .Where(d => d.Guid % 2 == 0)
        .Where(d => d.Guid > 1000)
        .Select(d => new BigDataSubsetDTO
        {
            Id = d.Guid,
            Email = d.Email
        }).ToList();
}
using (new TimedAction("AutoMapper Where().ToList().Select(o => Mapper.Map<DTO>(o))"))
{
    List<BigDataSubsetDTO> list2 = context.BigDataSets
        .Where(d => d.Guid % 2 == 0)
        .Where(d => d.Guid > 1000)
        .ToList()
        .Select(o => mapper.Map<BigDataSubsetDTO>(o))
        .ToList();
}
using (new TimedAction("AutoMapper .Where().ProjectTo<DTO>().ToList()"))
{
    List<BigDataSubsetDTO> list2 = context.BigDataSets
        .Where(d => d.Guid % 2 == 0)
        .Where(d => d.Guid > 1000)
        .ProjectTo<BigDataSubsetDTO>(mapper.ConfigurationProvider)
        .ToList();
}

