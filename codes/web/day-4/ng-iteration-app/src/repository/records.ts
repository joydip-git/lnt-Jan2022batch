import { Person } from "src/models/person"

export const places: string[] = ['Bangalore', 'Chennai', 'Mumbai']

export const people: Person[] = [{
    id: 1,
    name: 'joydip',
    salary: 1000,
    location: 'Bangalore'
}, {
    id: 2,
    name: 'sunil',
    salary: 2000,
    location: 'chennai'
}, {
    id: 3,
    name: 'anil',
    salary: 3000,
    location: 'chennai'
}]
/*
export const people: Person[] = [
    new Person('joydip', 1, 1000, 'bangalore')
]
*/
/**
 * Person[] people = new person[]
 * {
 *    
 * };
 * 
 */