# Sample-Asp.Net-Core-Repository-Pattern-Unit-of-Work

This is a sample C# Asp.Net core Asp.Net core repostitory pattern using Unit of Work, a class library which is independent of any layer. 

The Unit Of Work can be called from any business layer as follows.


 ```
 public class AuthDataService : IAuthDataService
    {
        private readonly IUnitOfWork _unit;

        public AuthDataService(IUnitOfWork unit)
        {
            _unit = unit;
        }

        private AuthDataService()
        {
            _unit = new UnitOfWork(new FuelManContext());
        }

        public User IsValidCredentials(LoginRequest request)
        {
            return _unit.Users.LoginDetailsMatched(request.Email, request.Password);
        }

        public void SignUp(User user)
        {
            _unit.Users.Add(user);
            _unit.Complete();
        }
    }
    ```
