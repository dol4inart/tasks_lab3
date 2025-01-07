class App
{

    private IService _service;

    public App(IService service)
    {
        _service = service;
    }

    public async void AsyncRun()
    {
        await _service.Run();
    }
}
