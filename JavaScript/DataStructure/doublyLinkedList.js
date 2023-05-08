class DoublyLinkedNode {
  constructor(val) {
    this.val = val;
    this.next = null;
    this.prev = null;
  }
}

class DoublyLinkedList {
  constructor() {
    this.head = null;
    this.tail = null;
    this.length = 0;
  }

  push(val) {
    var node = new DoublyLinkedNode(val);

    if (this.length === 0) {
      this.head = node;
      this.tail = node;
    } else {
      const prevTail = this.tail;
      prevTail.next = node;
      node.prev = prevTail;
      this.tail = node;
    }

    this.length++;
    return this;
  }

  pop() {
    if (this.length === 0) return undefined;

    const popedNode = this.tail;
    const prevNode = popedNode.prev;

    popedNode.prev = null;
    if (prevNode) prevNode.next = null;
    this.tail = prevNode;
    this.length--;
    if (this.length === 0) this.head = null;

    return popedNode;
  }

  unshift(val) {
    var newNode = new DoublyLinkedNode(val);

    if (this.length === 0) {
      this.head = newNode;
      this.tail = newNode;
    } else {
      const prevHead = this.head;
      prevHead.prev = newNode;
      newNode.next = prevHead;
      this.head = newNode;
    }

    this.length++;
    return this;
  }

  shift() {
    if (this.length === 0) return undefined;

    const currentHead = this.head;
    const newHead = currentHead.next;
    if (newHead) newHead.prev = null;
    this.head = newHead;
    this.length--;
    if (this.length === 0) this.tail = null;

    currentHead.next = null;
    return currentHead;
  }

  get(index) {
    if (index < 0 || index >= this.length) return undefined;

    let i = 0;
    let current = this.head;
    while (i < index) {
      current = current.next;
      i++;
    }

    return current;
  }

  reverse() {
    let current = this.head;
    this.head = this.tail;
    this.tail = current;

    let prevNode = current.next;
    let nextNode = null;

    while (current) {
      current.prev = prevNode;
      current.next = nextNode;
      current = current.prev;

      if (current) {
        prevNode = current.next;
        nextNode = current.prev;
      }
    }

    return this;
  }
}

const list = new DoublyLinkedList();
list.push('Hi');
list.push('There');
list.push('Its');
list.reverse();
console.log(list);
