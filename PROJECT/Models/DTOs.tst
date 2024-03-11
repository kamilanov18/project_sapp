${
    Template(Settings s)
    {
        s.OutputDirectory="../FRONTEND/Common/DTOs";
    }
}
$Classes(*DTO)[
export class $Name { 
    constructor(obj:Partial<$Name>) {
        Object.assign(this,obj);
    }
    $Properties[
    public $name: $Type;]
}]
