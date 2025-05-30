# GenericDataStructures

Bu proje, C# dili kullanılarak **generic** yapılar ile **kuyruk (Queue)**, **yığın (Stack)** ve **bağlı liste (LinkedList)** veri yapılarının detaylı ve kapsamlı implementasyonlarını içerir. Temel veri yapıları üzerine pratik yapmak isteyen veya kendi koleksiyonlarını oluşturmak isteyenler için hazırlanmıştır.

---

## İçindekiler

- [Genel Bakış](#genel-bakış)
- [Desteklenen Veri Yapıları](#desteklenen-veri-yapıları)
- [Özellikler](#özellikler)
- [Kullanım](#kullanım)
- [Proje Yapısı](#proje-yapısı)
- [Katkıda Bulunma](#katkıda-bulunma)

---

## Genel Bakış

.NET ortamında hazır koleksiyonların yanı sıra kendi generic veri yapılarınızı oluşturmayı ve yönetmeyi öğrenmek için örnek kodlar sağlar. Her yapı, tip güvenliği ve yeniden kullanılabilirlik için generic tiplerle tasarlanmıştır.

---

## Desteklenen Veri Yapıları

- **MyQueue<T>** : FIFO (First-In-First-Out) prensibine göre çalışan kuyruk yapısı.
- **MyStack<T>** : LIFO (Last-In-First-Out) prensibine göre çalışan yığın yapısı.
- **MyLinkedList<T>** : Tek yönlü bağlı liste yapısı.


---

## Özellikler

- Generic yapı desteği
- Temel operasyonlar: `Enqueue`, `Dequeue`, `Peek`, `Push`, `Pop`, `AddFirst`, `AddLast`, `Remove`, `Contains`, vb.
- Kolay okunabilir ve anlaşılır kod yapısı
- Hatalı durumlarda uygun istisna yönetimi (`InvalidOperationException` vb.)
- Konsol üzerinde kullanım için `Print()` metodu ile içerik gösterimi

---

## Kullanım

```csharp
var queue = new MyQueue<string>();
        queue.Enqueue("Elma");
        queue.Enqueue("Armut");
        queue.Print();
        Console.WriteLine("Peek: " + queue.Peek());
        queue.Dequeue();
        queue.Print();

        var stack = new MyStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Print();
        Console.WriteLine("Peek: " + stack.Peek());
        stack.Pop();
        stack.Print();

        var list = new MyLinkedList<double>();
        list.AddLast(1.1);
        list.AddFirst(0.5);
        list.AddLast(2.2);
        list.Print();
        Console.WriteLine("Contains 2.2? " + list.Contains(2.2));
        list.Remove(1.1);
        list.Print();
```
## Örnek Konsol Çıktısı
<img width="270" alt="Ekran Resmi 2025-05-30 10 32 05" src="https://github.com/user-attachments/assets/abee1b7e-bcb5-4c74-9c7f-95116343ac3c" />

## Katkıda Bulunma

Katkı yapmak istersen lütfen fork edip pull request gönder. Hatalar, öneriler veya yeni veri yapısı istekleri için issue açabilirsin.

## İletişim

Proje ile ilgili sorularınız veya önerileriniz için:

Email: dferhat263@gmail.com

