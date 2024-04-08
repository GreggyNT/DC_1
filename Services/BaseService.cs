using lab_1.Context;
using lab_1.Entities;

namespace lab_1.Services;

public class BaseService<T> where T : TblBase
{
    private readonly AppbContext _context;
    
}