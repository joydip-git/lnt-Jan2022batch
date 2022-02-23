class Person {
    
    private id: number;
    private name: string;
    private salary: number;

    constructor(id: number, name: string, salary: number) {
        this.id = id
        this.name = name
        this.salary = salary
    }

    public get Id(): number {
        return this.id
    }
    public set Id(val: number) {
        this.id = val
    }
    public set Name(val:string){
        this.name = val
    }
    public get Name():string{
        return this.name
    }
    public set Salary(val:number){
        this.salary = val
    }
    public get Salary():number{
        return this.salary
    }
}