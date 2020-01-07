namespace CitrusDB.Model
{
  class Validate
  {
    private bool _lockerForPb;
    private bool _backLockerPb;

    public Validate()
    {
      _lockerForPb = false;
      _backLockerPb = false;
    }

    public int DecreaseProgressBarLogic(int value, int points)
    {
      if (_backLockerPb)
      {
        if (value != 0)
          value -= points;

        _lockerForPb = true;
        _backLockerPb = false;
      }
      return value;
    }

    public int FillingProgressBarLogic(int value, int points)
    {
      if (_lockerForPb)
      {
        value += points;

        _lockerForPb = false;
        _backLockerPb = true;
      }
      return value;
    }

    public void SetState(bool haveMistake)
    {
      if (haveMistake)
      {
        _lockerForPb = true;
        _backLockerPb = false;
      }
      else
      {
        _lockerForPb = false;
        _backLockerPb = true;
      }
    }

    public void SetState(bool haveMistake, bool isSingle)
    {
      if (haveMistake)
      {
        _lockerForPb = true;
        _backLockerPb = false;
      }
      else if (isSingle) Reset();
    }

    public void Reset()
    {
      _lockerForPb = false;
      _backLockerPb = false;
    }
  }
}