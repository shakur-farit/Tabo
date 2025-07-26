using System;
using System.Collections.Generic;

namespace Assets.Code.Gameplay.Features.AStar
{
	public class PriorityQueue<T>
	{
		private readonly List<(T item, float priority)> _heap = new();
		private readonly Comparer<float> _comparer = Comparer<float>.Default;

		public int Count => _heap.Count;

		public void Enqueue(T item, float priority)
		{
			_heap.Add((item, priority));
			HeapifyUp(_heap.Count - 1);
		}

		public T Dequeue()
		{
			if (_heap.Count == 0) throw new InvalidOperationException("PriorityQueue is empty.");

			T item = _heap[0].item;
			_heap[0] = _heap[^1];
			_heap.RemoveAt(_heap.Count - 1);
			HeapifyDown(0);
			return item;
		}

		private void HeapifyUp(int index)
		{
			while (index > 0)
			{
				int parent = (index - 1) / 2;
				if (_comparer.Compare(_heap[index].priority, _heap[parent].priority) >= 0)
					break;

				(_heap[index], _heap[parent]) = (_heap[parent], _heap[index]);
				index = parent;
			}
		}

		private void HeapifyDown(int index)
		{
			int lastIndex = _heap.Count - 1;
			while (true)
			{
				int left = index * 2 + 1;
				int right = index * 2 + 2;
				int smallest = index;

				if (left <= lastIndex && _comparer.Compare(_heap[left].priority, _heap[smallest].priority) < 0)
					smallest = left;

				if (right <= lastIndex && _comparer.Compare(_heap[right].priority, _heap[smallest].priority) < 0)
					smallest = right;

				if (smallest == index)
					break;

				(_heap[index], _heap[smallest]) = (_heap[smallest], _heap[index]);
				index = smallest;
			}
		}
	}
}