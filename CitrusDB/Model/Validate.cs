namespace CitrusDB.Model
{
  class Validate
  {
    private bool _lockerForPB;
    private bool _backLockerPB;

    public Validate()
    {
      _lockerForPB = false;
      _backLockerPB = false;
    }

    public int DecreaseProgressBarLogic(int value, int points)
    {
      if (_backLockerPB == true)
      {
        if (value != 0)
          value -= points;

        _lockerForPB = true;
        _backLockerPB = false;
      }
      return value;
    }

    public int FillingProgressBarLogic(int value, int points)
    {
      if (_lockerForPB == true)
      {
        value += points;

        _lockerForPB = false;
        _backLockerPB = true;
      }
      return value;
    }

    public void SetState(bool haveMistake)
    {
      if (haveMistake)
      {
        _lockerForPB = true;
        _backLockerPB = false;
      }
      else
      {
        _lockerForPB = false;
        _backLockerPB = true;
      }
    }

    public void SetState(bool haveMistake, bool isSingle)
    {
      if (haveMistake)
      {
        _lockerForPB = true;
        _backLockerPB = false;
      }
      else if (isSingle) Reset();
    }

    public void Reset()
    {
      _lockerForPB = false;
      _backLockerPB = false;
    }
  }
}