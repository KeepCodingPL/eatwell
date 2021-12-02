package com.keepcodingpl.eatwell.feed_fragment.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.navigation.Navigation
import androidx.recyclerview.widget.AsyncListDiffer
import androidx.recyclerview.widget.DiffUtil
import androidx.recyclerview.widget.RecyclerView
import com.bumptech.glide.Glide
import com.keepcodingpl.eatwell.databinding.ItemMealBinding
import com.keepcodingpl.eatwell.main_fragment.MainFragmentDirections
import com.keepcodingpl.eatwell.model.Meal

class FeedFragmentAdapter :
    RecyclerView.Adapter<FeedFragmentAdapter.MyViewHolder>() {

    inner class MyViewHolder(val binding: ItemMealBinding) : RecyclerView.ViewHolder(binding.root) {
        fun bind(meal: Meal) {
            binding.apply {
                Glide.with(itemView)
                    .load(meal.image)
                    .into(imageView)
                name.text = meal.name
            }
        }
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MyViewHolder {
        val binding = ItemMealBinding.inflate(LayoutInflater.from(parent.context), parent, false)
        return MyViewHolder(binding)
    }

    override fun onBindViewHolder(holder: MyViewHolder, position: Int) {
        val mealList = meals[position]
        holder.bind(mealList)

        holder.binding.root.setOnClickListener {
            val action =
                MainFragmentDirections.actionMainFragmentToDetailsFragment(holder.binding.mealNameXML.text.toString())
            Navigation.findNavController(it).navigate(action)
        }
    }

    private val diffUtil = object : DiffUtil.ItemCallback<Meal>() {
        override fun areItemsTheSame(oldItem: Meal, newItem: Meal): Boolean {
            return oldItem == newItem
        }

        override fun areContentsTheSame(oldItem: Meal, newItem: Meal): Boolean {
            return oldItem == newItem
        }
    }

    private val recyclerListDiffer = AsyncListDiffer(this, diffUtil)

     var meals: List<Meal>
        get() = recyclerListDiffer.currentList
        set(value) = recyclerListDiffer.submitList(value)

    override fun getItemCount() = meals.size
}