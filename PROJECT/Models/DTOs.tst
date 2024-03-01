${
    Template(Settings s)
    {
        s.OutputDirectory="../FRONTEND/Common/DTOs";
    }
}

module Models { $Classes(*DTO)[
    export class $Name { $Properties[
        public $name: $Type;]
    }]
}