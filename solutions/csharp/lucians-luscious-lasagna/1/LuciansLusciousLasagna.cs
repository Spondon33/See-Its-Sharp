class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ExpectedMinutesInOven(){
        return 40;
    }
    public int RemainingMinutesInOven(int x){
        return 40 - x;
    }
    public int PreparationTimeInMinutes(int x){
        return 2 * x;
    }
    public int ElapsedTimeInMinutes(int layer, int min){
        return PreparationTimeInMinutes(layer) + min;
    }
}
