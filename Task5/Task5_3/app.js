'use strict';

//var storage = new Service();
//storage.add(); //принимает объект и позволяет добавить его в коллекцию
//storage.getById(); //принимает id и возвращает найденный объект или NULL если не найден
//stotage.getAll(); //возвращает весь массив объектов
//storage.deleteById(); //принимает id и возвращает удаленный объект
//storage.updateById(); // принимает id первым параметром и объект-вторым. Обновляет поля объекта новыми значениями
//storage.replaceById(); // принимает id и заменяет старый объект - новым

class Service {
    constructor() {
        this.items = new Array();
        this.id = 0;
    }

    checkId(id) {
        return typeof id === "string";
    }

    checkObj(obj) {
        return typeof obj === "object" && obj != null;
    }

    add(obj) {
        if (this.checkObj(obj)) {
            this.id++;
            obj.id = "id" + this.id;
            this.items.push(obj);
        }
    }

    searchById(id) {
        for (let i = 0; i < this.items.length; i++) {
            if (this.items[i].id == id) {
                return this.items[i];
            }
        }
        return null;
    }

    getById(id) {
        if (this.checkId(id)) {
            return this.searchById(id);
        }
    }

    getAll() {
        return this.items;
    }

    deleteById(id) {
        if (this.checkId(id)) {
            let temp = this.searchById(id);
            if (temp != null) {
                this.items.splice(this.items.indexOf(temp), 1);
                return temp;
            }
        }
    }

    updateById(id, obj) {
        if (this.checkId(id) && this.checkObj(obj)) {
            let temp = this.searchById(id);
            if (temp != null) {
                for (let prop in obj) {
                    temp[prop] = obj[prop];
                }
            }
        }
    }

    replaceById(id, obj) {
        if (this.checkId(id) && this.checkObj(obj)) {
            let temp = this.searchById(id);
            if (temp != null) {
                obj.id = id;
                this.items[this.items.indexOf(temp)] = obj;
            }
        }
    }
}

module.exports = Service;