namespace Design_Patterns.Structural_Patterns.Facade
{
    public interface IFacadeService
    {
        public ILoginUserService LoginUserService { get; }
        public IRegisterUserService RegisterUserService { get; }
    }
    public class FacadeService : IFacadeService
    {

        private ILoginUserService _loginUserService;
        public ILoginUserService LoginUserService
        {
            get
            {
                return _loginUserService = _loginUserService ?? new LoginUserService();
            }
        }


        private IRegisterUserService _registerUserService;
        public IRegisterUserService RegisterUserService
        {
            get
            {
                return _registerUserService = _registerUserService ?? new RegisterUserService();
            }
        }
    }

    public interface ILoginUserService
    {
        void Execute();
    }
    public class LoginUserService : ILoginUserService
    {
        public void Execute()
        {
            Action1();
            Action2();
            Action3();
        }

        private void Action1() { }
        private void Action2() { }
        private void Action3() { }

    }
    public interface IRegisterUserService
    {
        void Execute();
    }
    public class RegisterUserService : IRegisterUserService
    {
        public void Execute()
        {
            action1();
        }

        private void action1()
        {
        }

    }


    //services.AddSingleton<IFacadeService, FacadeService>();
    //private readonly IFacadeService _facadeService;
    //public TargetConreoller(IFacadeService facadeService)
    //{
    //    _facadeService = facadeService;
    //}
    //
    //public IActionResult Test()
    //{
    //    _facadeService.RegisterUserService.Execute();
    //    _facadeService.LoginUserService.Execute();
    //}
}
