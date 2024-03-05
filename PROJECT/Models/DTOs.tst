${
    Template(Settings s)
    {
        s.OutputDirectory="../FRONTEND/Common/DTOs";
    }
}
$Classes(*DTO)[
export class $Name { $Properties[
    public $name: $Type;]
}]
