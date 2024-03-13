${
    Template(Settings s)
    {
        s.OutputDirectory="../FRONTEND/Common/DTOs";
    }
}
$Classes(*DTO)[
export class $Name { 
<<<<<<< Updated upstream
    constructor(obj:Partial<$Name>) {
        Object.assign(this,obj);
    }
    $Properties[
=======
    constructor(obj: Partial<$Name>) {
        Object.assign(this,obj);
    }$Properties[
>>>>>>> Stashed changes
    public $name: $Type;]
}]
