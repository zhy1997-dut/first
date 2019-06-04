clear all
clc
seed=1;
retest5=zeros(20,684);
seed_arr=randi([1,1000],20,1);
t_arr=30*rand(20,1)+3;
for i=1:20
    seed=seed_arr(i,1);
    t=t_arr(i,1);
    sim("testc4.slx");
    retest5(i,:)=yc5;
end

stairs(tout,retest5')
save retest5.mat retest5;