using EFCoreTesting.Performace.AutoMapper;

using BigDataContext context = new();
using (new TimedAction())
{
    List<BigDataSubsetDTO> list = context.BigDataSets
        .Where(d => d.Id % 2 == 0)
        .Where(d => d.Id > 1000)
        .Select(d => new BigDataSubsetDTO
        {
            Id = d.Id,
            Email = d.Email
        }).ToList();
}
using (new TimedAction())
{
    List<BigDataSubsetDTO> list2 = context.BigDataSets
        .ToList()
        .Where(d => d.Id % 2 == 0)
        .Where(d => d.Id > 1000)
        .Select(d => new BigDataSubsetDTO
        {
            Id = d.Id,
            Email = d.Email
        }).ToList();
}

