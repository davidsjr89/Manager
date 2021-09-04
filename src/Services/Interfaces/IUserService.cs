using System.Collections.Generic;
using System.Threading.Tasks;
using Services.DTO;

namespace Services.Interfaces
{
    public interface IUserService
    {
         Task<UserDTO> Create(UserDTO userDTO);
         Task<UserDTO> Update(UserDTO userDTO);
         Task Remove(long id);
         Task<UserDTO> Get(long id);
         Task<List<UserDTO>> Get();
         Task<UserDTO> SearchByName(string name);
         Task<UserDTO> SearchByEmail(string email);
         Task<UserDTO> GetByEmail(string email);
    }
}